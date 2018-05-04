using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace server_Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpListener serverSocketListener;
        TcpClient clientSockets;
        bool server_check=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbSelectOperation.Enabled = false;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            //server_check = false;
            if (btnServer.Text == "START SERVER" && server_check == false)
            {
                // Starting the server
                serverSocketListener = new TcpListener(8888);
                clientSockets = default(TcpClient);
                lblServerCurrentStatus.Text = "Server started successfully, waiting for the clients to connect...";
                serverSocketListener.Start();
                
                clientSockets = serverSocketListener.AcceptTcpClient();
                lblServerCurrentStatus.Text = "Client Connected successfully.";
                cbSelectOperation.Enabled = true;
                cbSelectOperation.SelectedIndex = 0;
                lblCurrentstatus.Text = "Waiting for data transfer";
            }
            else if (btnServer.Text == "STOP SERVER" && server_check == true)
            {
                clientSockets.Close();
                serverSocketListener.Stop();
                lblServerCurrentStatus.Text = "Server stopped successfully.";
            }
            if (server_check == false)
            {
                server_check = true;
                btnServer.Text = "STOP SERVER";
               
            }
            else if (server_check == true)
            {
                server_check = false;
                btnServer.Text = "START SERVER";
            }
        }

        private void cbSelectOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetworkStream networkStream;
            int retry = 0;
            if (cbSelectOperation.SelectedIndex == 1  && cbSelectOperation.Text == "Send")
            {
                lblCurrentstatus.Text = "Sending data..";
                cbSelectOperation.Enabled = false;
                string[] fileContent = null;
                networkStream = clientSockets.GetStream();
                try
                {
                    openFileDialog1.ShowDialog();
                    lblFileName.Text = "File: " + System.IO.Path.GetFileName(openFileDialog1.FileName);
                    fileContent = System.IO.File.ReadAllLines(openFileDialog1.FileName.ToString());

                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        if (fileContent[i] == "")
                        {
                            string line = "emptyline";
                            lblActualData.Text = "empty line data..";
                            Byte[] sendBytes = frameForm(line, fileContent.Length, i);
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                        }
                        else
                        {
                            lblActualData.Text = fileContent[i].ToString();
                            Byte[] sendBytes = frameForm(fileContent[i], fileContent.Length, i);
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                        }
                        System.Threading.Thread.Sleep(10);
                        byte[] bytesFrom = new byte[10];
                        networkStream.Read(bytesFrom, 0, 10);
                        bool check = ackCheck(bytesFrom);
                        if (check == false)
                        {
                            retry = retry + 1;
                            i = i - 1;
                        }
                        if (retry == 3)
                        {
                            break;
                        }
                    }
                    if (retry == 3)
                    {
                        // closing packet sending
                        lblActualData.Text = "Sending stopped due to error..";
                        byte[] closeFrame = frameForm("stop", 1, 1);
                        networkStream.Write(closeFrame, 0, closeFrame.Length);
                        lblActualData.Text = "File transfer stopped..";
                    }
                    else
                    {
                        // closing packet sending
                        lblActualData.Text = "Sending closing packet..";
                        byte[] closeFrame = frameForm("close", 1, 1);
                        networkStream.Write(closeFrame, 0, closeFrame.Length);
                        lblActualData.Text = "File Sent successfully..";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File selection failure/file not found, please check..");
                    cbSelectOperation.SelectedIndex = 0;
                }
                networkStream.Flush();
                cbSelectOperation.SelectedIndex = 0;
            }
            else if (cbSelectOperation.SelectedIndex == 2 && cbSelectOperation.Text == "Receive")
            {
                lblCurrentstatus.Text = "Receiving data..";
                string data_stop = "";
                cbSelectOperation.Enabled = false;
                bool loop_check = true;
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Shreya\Documents\Writehere.txt");
                while (loop_check == true)
                {
                    try
                    {
                        networkStream = clientSockets.GetStream();
                        byte[] bytesFrom = new byte[65536];
                        networkStream.Read(bytesFrom, 0, (int)clientSockets.ReceiveBufferSize);
                        Array.Resize(ref bytesFrom, 6 + bytesFrom[3]);
                        int totalPkts = bytesFrom[1];
                        int currentPkt = bytesFrom[2];
                        //if (totalPkts == currentPkt)
                        //{ break; }
                        string data = parseData(bytesFrom);
                        if (data == "close")
                        {
                            break;
                        }
                        if (data == "stop")
                        {
                            data_stop = "stop";
                            break;
                        }
                        if (data == "emptyline")
                        {
                            file.WriteLine("\n");
                            lblActualData.Text = "Empty line data..";
                            networkStream.Write(ackframeForm("Pass"), 0, ackframeForm("Pass").Length);
                        }
                        else if (data != "")
                        {
                            lblActualData.Text = data;
                            //have to write into a file + need to send the ack packet
                            networkStream.Write(ackframeForm("Pass"), 0, ackframeForm("Pass").Length);
                            file.WriteLine(data);
                        }
                        else
                        {
                            networkStream.Write(ackframeForm("Fail"), 0, ackframeForm("Fail").Length);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        file.Close();
                        cbSelectOperation.SelectedIndex = 0;
                    }
                    if (data_stop == "stop")
                    {
                        cbSelectOperation.SelectedIndex = 0;
                        lblActualData.Text = "File transfer failed due to checksum error..";
                       
                    }
                    else
                    {
                        lblActualData.Text = "File received successfully..";
                        cbSelectOperation.SelectedIndex = 0;
                    }
                }
                file.Close();
            }
            lblCurrentstatus.Text = "File transfer successful..";
            cbSelectOperation.Enabled = true;
        }
        public byte[] frameForm(string lineData,int totalLength, int currentPktNum)
        {
            byte[] data_frm = new byte[65536];
            try
            {
                int index = 0;
                data_frm[index++] = 0xaa; //Start of the packet - unique identification
                data_frm[index++] = (byte)totalLength; //number of packets
                data_frm[index++] = (byte)currentPktNum; //current packet number
                data_frm[index++] = (byte)lineData.Length; //current data length
                Byte[] dataBytes = Encoding.ASCII.GetBytes(lineData); //data
                Buffer.BlockCopy(dataBytes, 0, data_frm, index, dataBytes.Length); //copying data to original array
                data_frm[dataBytes.Length-1 + index+1] = calCheckSum(data_frm,1,dataBytes.Length+index); //checksum portion
                data_frm[dataBytes.Length-1 + index+2] = 0x99; //end of packet - unique identification
                Array.Resize(ref data_frm, dataBytes.Length + index+2); //resizing the array to actual size
            }
            catch (Exception ex)
            {
                data_frm = null;
            }
            return data_frm;
        }
        public byte[] ackframeForm(string data)
        {
            byte[] ack_frm = new byte[65536];
            try
            {
                int index = 0;
                ack_frm[index++] = 0xaa; //Start of the packet - unique identification
                ack_frm[index++] = 0x01; //number of packets
                ack_frm[index++] = 0x01; //current packet number
                ack_frm[index++] = 0x04; //current data length
                Byte[] dataBytes = Encoding.ASCII.GetBytes(data); //data
                Buffer.BlockCopy(dataBytes, 0, ack_frm, index, dataBytes.Length); //copying data to original array
                ack_frm[dataBytes.Length - 1 + index + 1] = calCheckSum(ack_frm, 1, dataBytes.Length + index); //checksum portion
                ack_frm[dataBytes.Length - 1 + index + 2] = 0x99; //end of packet - unique identification
                Array.Resize(ref ack_frm, dataBytes.Length + index + 2); //resizing the array to actual size
            }
            catch (Exception ex)
            {
                ack_frm = null;
            }
            return ack_frm;
        }
        public string parseData(byte[] receiveData)
        {
            string actualData = "";
            try
            {
                int totalPckts = receiveData[1]; //retriving totoal number of packets count.
                int currentPktNum = receiveData[2]; //current packet number
                int dataLength = receiveData[3]; //actual data length
                byte chkSum = calCheckSum(receiveData, 1, receiveData.Length - 2); //Re-calculate the checksum
                if (chkSum == receiveData[receiveData.Length - 2])
                {
                    byte[] data = new byte[dataLength];
                    Array.Copy(receiveData, 4, data, 0, dataLength);
                    actualData = System.Text.Encoding.ASCII.GetString(data);
                }
                else
                {
                    actualData = "";
                    MessageBox.Show("Checksum Error Found.");
                }
            }
            catch (Exception ex)
            {
                actualData = "";
            }
            return actualData;
        }
        public byte calCheckSum(byte[] data_frm,int startindex,int endindex)
        {
            byte chkSum = 0x0;
            try
            {
                for (int i = startindex; i < endindex; i++)
                {
                    chkSum ^= data_frm[i];
                }
            }
            catch (Exception ex)
            {
                chkSum = 0x0;
            }
            return chkSum;
        }
        public bool ackCheck(byte[] ack_pkt)
        {
            bool flag = false;
            try
            {
                string ack = System.Text.Encoding.ASCII.GetString(ack_pkt);
                if (ack.Contains("Pass") || ack.Contains("PASS") || ack.Contains("pass"))
                {
                    flag = true;
                }
                else { flag = false; }
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return flag;
        }

		private void lblActualData_Click(object sender, EventArgs e)
		{

		}

		private void lblCurrentstatus_Click(object sender, EventArgs e)
		{

		}

		private void lblData_Click(object sender, EventArgs e)
		{

		}
	}
}
