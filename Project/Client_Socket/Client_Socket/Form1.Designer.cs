namespace Client_Socket
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnClient = new System.Windows.Forms.Button();
			this.lblCurrentStatus = new System.Windows.Forms.Label();
			this.lblClientCurrentStatus = new System.Windows.Forms.Label();
			this.lblAction = new System.Windows.Forms.Label();
			this.cbActionSelection = new System.Windows.Forms.ComboBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblDatastatus = new System.Windows.Forms.Label();
			this.lblActualData = new System.Windows.Forms.Label();
			this.lblFileName = new System.Windows.Forms.Label();
			this.btnStopClient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClient
			// 
			this.btnClient.BackColor = System.Drawing.Color.SteelBlue;
			this.btnClient.ForeColor = System.Drawing.Color.White;
			this.btnClient.Location = new System.Drawing.Point(130, 24);
			this.btnClient.Margin = new System.Windows.Forms.Padding(4);
			this.btnClient.Name = "btnClient";
			this.btnClient.Size = new System.Drawing.Size(271, 65);
			this.btnClient.TabIndex = 1;
			this.btnClient.Text = "START";
			this.btnClient.UseVisualStyleBackColor = false;
			this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
			// 
			// lblCurrentStatus
			// 
			this.lblCurrentStatus.AutoSize = true;
			this.lblCurrentStatus.ForeColor = System.Drawing.Color.Black;
			this.lblCurrentStatus.Location = new System.Drawing.Point(37, 120);
			this.lblCurrentStatus.Name = "lblCurrentStatus";
			this.lblCurrentStatus.Size = new System.Drawing.Size(381, 39);
			this.lblCurrentStatus.TabIndex = 3;
			this.lblCurrentStatus.Text = "Client Current Status :";
			this.lblCurrentStatus.Click += new System.EventHandler(this.lblCurrentStatus_Click);
			// 
			// lblClientCurrentStatus
			// 
			this.lblClientCurrentStatus.AutoSize = true;
			this.lblClientCurrentStatus.ForeColor = System.Drawing.Color.Green;
			this.lblClientCurrentStatus.Location = new System.Drawing.Point(313, 120);
			this.lblClientCurrentStatus.Name = "lblClientCurrentStatus";
			this.lblClientCurrentStatus.Size = new System.Drawing.Size(0, 39);
			this.lblClientCurrentStatus.TabIndex = 4;
			// 
			// lblAction
			// 
			this.lblAction.AutoSize = true;
			this.lblAction.ForeColor = System.Drawing.Color.Black;
			this.lblAction.Location = new System.Drawing.Point(37, 191);
			this.lblAction.Name = "lblAction";
			this.lblAction.Size = new System.Drawing.Size(371, 39);
			this.lblAction.TabIndex = 5;
			this.lblAction.Text = "Select Mode              :";
			// 
			// cbActionSelection
			// 
			this.cbActionSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbActionSelection.ForeColor = System.Drawing.Color.Blue;
			this.cbActionSelection.FormattingEnabled = true;
			this.cbActionSelection.Items.AddRange(new object[] {
            "<---Select--->",
            "Send",
            "Receive"});
			this.cbActionSelection.Location = new System.Drawing.Point(445, 191);
			this.cbActionSelection.Name = "cbActionSelection";
			this.cbActionSelection.Size = new System.Drawing.Size(245, 47);
			this.cbActionSelection.TabIndex = 6;
			this.cbActionSelection.SelectedIndexChanged += new System.EventHandler(this.cbActionSelection_SelectedIndexChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = System.Drawing.Color.Black;
			this.lblStatus.Location = new System.Drawing.Point(37, 340);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(383, 39);
			this.lblStatus.TabIndex = 7;
			this.lblStatus.Text = "File Status                  :";
			this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
			// 
			// lblDatastatus
			// 
			this.lblDatastatus.AutoSize = true;
			this.lblDatastatus.ForeColor = System.Drawing.Color.Green;
			this.lblDatastatus.Location = new System.Drawing.Point(378, 258);
			this.lblDatastatus.Name = "lblDatastatus";
			this.lblDatastatus.Size = new System.Drawing.Size(0, 39);
			this.lblDatastatus.TabIndex = 8;
			// 
			// lblActualData
			// 
			this.lblActualData.AutoSize = true;
			this.lblActualData.ForeColor = System.Drawing.Color.Green;
			this.lblActualData.Location = new System.Drawing.Point(438, 340);
			this.lblActualData.Name = "lblActualData";
			this.lblActualData.Size = new System.Drawing.Size(0, 39);
			this.lblActualData.TabIndex = 9;
			this.lblActualData.Click += new System.EventHandler(this.lblActualData_Click);
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.ForeColor = System.Drawing.Color.Black;
			this.lblFileName.Location = new System.Drawing.Point(745, 191);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(195, 39);
			this.lblFileName.TabIndex = 10;
			this.lblFileName.Text = "FileName :";
			this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
			// 
			// btnStopClient
			// 
			this.btnStopClient.BackColor = System.Drawing.Color.SteelBlue;
			this.btnStopClient.ForeColor = System.Drawing.Color.White;
			this.btnStopClient.Location = new System.Drawing.Point(578, 24);
			this.btnStopClient.Margin = new System.Windows.Forms.Padding(4);
			this.btnStopClient.Name = "btnStopClient";
			this.btnStopClient.Size = new System.Drawing.Size(257, 65);
			this.btnStopClient.TabIndex = 11;
			this.btnStopClient.Text = "STOP";
			this.btnStopClient.UseVisualStyleBackColor = false;
			this.btnStopClient.Click += new System.EventHandler(this.btnStopClient_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1378, 693);
			this.Controls.Add(this.btnStopClient);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.lblActualData);
			this.Controls.Add(this.lblDatastatus);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.cbActionSelection);
			this.Controls.Add(this.lblAction);
			this.Controls.Add(this.lblClientCurrentStatus);
			this.Controls.Add(this.lblCurrentStatus);
			this.Controls.Add(this.btnClient);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "CLIENT";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblClientCurrentStatus;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cbActionSelection;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDatastatus;
        private System.Windows.Forms.Label lblActualData;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnStopClient;
    }
}

