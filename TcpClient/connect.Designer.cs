namespace TcpClient
{
    partial class connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connect));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit_connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcpConnect = new System.Windows.Forms.Button();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBoardRate = new System.Windows.Forms.ComboBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.btnExit_connect);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnExit_connect
            // 
            this.btnExit_connect.BackColor = System.Drawing.Color.Cornsilk;
            resources.ApplyResources(this.btnExit_connect, "btnExit_connect");
            this.btnExit_connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit_connect.Name = "btnExit_connect";
            this.btnExit_connect.UseVisualStyleBackColor = false;
            this.btnExit_connect.Click += new System.EventHandler(this.btnExit_connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcpConnect);
            this.groupBox1.Controls.Add(this.txtLocalPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIPaddress);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnTcpConnect
            // 
            this.btnTcpConnect.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btnTcpConnect, "btnTcpConnect");
            this.btnTcpConnect.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnTcpConnect.Name = "btnTcpConnect";
            this.btnTcpConnect.UseVisualStyleBackColor = false;
            this.btnTcpConnect.Click += new System.EventHandler(this.btnTcpConnect_Click);
            // 
            // txtLocalPort
            // 
            resources.ApplyResources(this.txtLocalPort, "txtLocalPort");
            this.txtLocalPort.Name = "txtLocalPort";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // txtIPaddress
            // 
            resources.ApplyResources(this.txtIPaddress, "txtIPaddress");
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.TextChanged += new System.EventHandler(this.txtIPaddress_TextChanged);
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBoardRate);
            this.groupBox3.Controls.Add(this.cmbSerialPort);
            this.groupBox3.Controls.Add(this.btnSerial);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cmbBoardRate
            // 
            this.cmbBoardRate.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoardRate, "cmbBoardRate");
            this.cmbBoardRate.Name = "cmbBoardRate";
            this.cmbBoardRate.Sorted = true;
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSerialPort, "cmbSerialPort");
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Sorted = true;
            // 
            // btnSerial
            // 
            this.btnSerial.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btnSerial, "btnSerial");
            this.btnSerial.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.UseVisualStyleBackColor = false;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // connect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connect_FormClosing);
            this.Load += new System.EventHandler(this.connect_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTcpConnect;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBoardRate;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit_connect;
    }
}