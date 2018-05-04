namespace server_Socket
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
			this.btnServer = new System.Windows.Forms.Button();
			this.lblServerStatus = new System.Windows.Forms.Label();
			this.lblServerCurrentStatus = new System.Windows.Forms.Label();
			this.lblSelectActionn = new System.Windows.Forms.Label();
			this.cbSelectOperation = new System.Windows.Forms.ComboBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblData = new System.Windows.Forms.Label();
			this.lblCurrentstatus = new System.Windows.Forms.Label();
			this.lblActualData = new System.Windows.Forms.Label();
			this.lblFileName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnServer
			// 
			this.btnServer.BackColor = System.Drawing.Color.SteelBlue;
			this.btnServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnServer.Location = new System.Drawing.Point(177, 7);
			this.btnServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnServer.Name = "btnServer";
			this.btnServer.Size = new System.Drawing.Size(989, 72);
			this.btnServer.TabIndex = 0;
			this.btnServer.Text = "START SERVER";
			this.btnServer.UseVisualStyleBackColor = false;
			this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
			// 
			// lblServerStatus
			// 
			this.lblServerStatus.AutoSize = true;
			this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServerStatus.ForeColor = System.Drawing.Color.Black;
			this.lblServerStatus.Location = new System.Drawing.Point(90, 99);
			this.lblServerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblServerStatus.Name = "lblServerStatus";
			this.lblServerStatus.Size = new System.Drawing.Size(395, 39);
			this.lblServerStatus.TabIndex = 2;
			this.lblServerStatus.Text = "Server Current Status :";
			// 
			// lblServerCurrentStatus
			// 
			this.lblServerCurrentStatus.AutoSize = true;
			this.lblServerCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServerCurrentStatus.ForeColor = System.Drawing.Color.Green;
			this.lblServerCurrentStatus.Location = new System.Drawing.Point(363, 99);
			this.lblServerCurrentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblServerCurrentStatus.Name = "lblServerCurrentStatus";
			this.lblServerCurrentStatus.Size = new System.Drawing.Size(0, 39);
			this.lblServerCurrentStatus.TabIndex = 3;
			// 
			// lblSelectActionn
			// 
			this.lblSelectActionn.AutoSize = true;
			this.lblSelectActionn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectActionn.ForeColor = System.Drawing.Color.Black;
			this.lblSelectActionn.Location = new System.Drawing.Point(88, 177);
			this.lblSelectActionn.Name = "lblSelectActionn";
			this.lblSelectActionn.Size = new System.Drawing.Size(381, 39);
			this.lblSelectActionn.TabIndex = 4;
			this.lblSelectActionn.Text = "Select Mode               :";
			// 
			// cbSelectOperation
			// 
			this.cbSelectOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSelectOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSelectOperation.FormattingEnabled = true;
			this.cbSelectOperation.Items.AddRange(new object[] {
            "<---Select--->",
            "Send",
            "Receive"});
			this.cbSelectOperation.Location = new System.Drawing.Point(514, 174);
			this.cbSelectOperation.Name = "cbSelectOperation";
			this.cbSelectOperation.Size = new System.Drawing.Size(287, 47);
			this.cbSelectOperation.TabIndex = 5;
			this.cbSelectOperation.SelectedIndexChanged += new System.EventHandler(this.cbSelectOperation_SelectedIndexChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblData.ForeColor = System.Drawing.Color.Black;
			this.lblData.Location = new System.Drawing.Point(88, 320);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(393, 39);
			this.lblData.TabIndex = 6;
			this.lblData.Text = "File Status                   :";
			this.lblData.Click += new System.EventHandler(this.lblData_Click);
			// 
			// lblCurrentstatus
			// 
			this.lblCurrentstatus.AutoSize = true;
			this.lblCurrentstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentstatus.ForeColor = System.Drawing.Color.Green;
			this.lblCurrentstatus.Location = new System.Drawing.Point(626, 250);
			this.lblCurrentstatus.Name = "lblCurrentstatus";
			this.lblCurrentstatus.Size = new System.Drawing.Size(0, 39);
			this.lblCurrentstatus.TabIndex = 7;
			this.lblCurrentstatus.Click += new System.EventHandler(this.lblCurrentstatus_Click);
			// 
			// lblActualData
			// 
			this.lblActualData.AutoSize = true;
			this.lblActualData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActualData.Location = new System.Drawing.Point(528, 320);
			this.lblActualData.Name = "lblActualData";
			this.lblActualData.Size = new System.Drawing.Size(0, 39);
			this.lblActualData.TabIndex = 8;
			this.lblActualData.Click += new System.EventHandler(this.lblActualData_Click);
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFileName.Location = new System.Drawing.Point(922, 177);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(0, 39);
			this.lblFileName.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 46F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1297, 519);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.lblActualData);
			this.Controls.Add(this.lblCurrentstatus);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.cbSelectOperation);
			this.Controls.Add(this.lblSelectActionn);
			this.Controls.Add(this.lblServerCurrentStatus);
			this.Controls.Add(this.lblServerStatus);
			this.Controls.Add(this.btnServer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SERVER";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label lblServerCurrentStatus;
        private System.Windows.Forms.Label lblSelectActionn;
        private System.Windows.Forms.ComboBox cbSelectOperation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCurrentstatus;
        private System.Windows.Forms.Label lblActualData;
        private System.Windows.Forms.Label lblFileName;
    }
}

