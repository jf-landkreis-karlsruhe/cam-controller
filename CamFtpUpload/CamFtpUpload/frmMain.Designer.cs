namespace CamFtpUpload
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uploadTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblLastUpload = new System.Windows.Forms.Label();
            this.txtLocalDir1 = new System.Windows.Forms.TextBox();
            this.txtLocalDir2 = new System.Windows.Forms.TextBox();
            this.txtRemoteFile1 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemoteFile2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemoteDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemoteServer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDuration1 = new System.Windows.Forms.Label();
            this.lblDuration2 = new System.Windows.Forms.Label();
            this.txtImageUploadWidth = new System.Windows.Forms.TextBox();
            this.labelUploadImageWidth = new System.Windows.Forms.Label();
            this.tipUploadImageWidth = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Directory [1]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Directory [2]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remote File [1]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // uploadTimer
            // 
            this.uploadTimer.Interval = 60000;
            this.uploadTimer.Tick += new System.EventHandler(this.uploadTimer_Tick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(16, 354);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 28);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblLastUpload
            // 
            this.lblLastUpload.AutoSize = true;
            this.lblLastUpload.Location = new System.Drawing.Point(155, 359);
            this.lblLastUpload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUpload.Name = "lblLastUpload";
            this.lblLastUpload.Size = new System.Drawing.Size(86, 17);
            this.lblLastUpload.TabIndex = 6;
            this.lblLastUpload.Text = "Last upload:";
            // 
            // txtLocalDir1
            // 
            this.txtLocalDir1.Location = new System.Drawing.Point(159, 20);
            this.txtLocalDir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalDir1.Name = "txtLocalDir1";
            this.txtLocalDir1.Size = new System.Drawing.Size(800, 22);
            this.txtLocalDir1.TabIndex = 7;
            this.txtLocalDir1.Text = "C:\\CAM1";
            // 
            // txtLocalDir2
            // 
            this.txtLocalDir2.Location = new System.Drawing.Point(159, 52);
            this.txtLocalDir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalDir2.Name = "txtLocalDir2";
            this.txtLocalDir2.Size = new System.Drawing.Size(800, 22);
            this.txtLocalDir2.TabIndex = 8;
            this.txtLocalDir2.Text = "C:\\CAM2";
            // 
            // txtRemoteFile1
            // 
            this.txtRemoteFile1.Location = new System.Drawing.Point(159, 148);
            this.txtRemoteFile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemoteFile1.Name = "txtRemoteFile1";
            this.txtRemoteFile1.Size = new System.Drawing.Size(800, 22);
            this.txtRemoteFile1.TabIndex = 9;
            this.txtRemoteFile1.Text = "cam1.jpg";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(159, 277);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(800, 22);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.Text = "f007e15a";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 309);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(800, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Remote File [2]:";
            // 
            // txtRemoteFile2
            // 
            this.txtRemoteFile2.Location = new System.Drawing.Point(159, 180);
            this.txtRemoteFile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemoteFile2.Name = "txtRemoteFile2";
            this.txtRemoteFile2.Size = new System.Drawing.Size(800, 22);
            this.txtRemoteFile2.TabIndex = 13;
            this.txtRemoteFile2.Text = "cam2.jpg";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 245);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Update duration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "minutes";
            // 
            // txtRemoteDir
            // 
            this.txtRemoteDir.Location = new System.Drawing.Point(159, 116);
            this.txtRemoteDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemoteDir.Name = "txtRemoteDir";
            this.txtRemoteDir.Size = new System.Drawing.Size(800, 22);
            this.txtRemoteDir.TabIndex = 18;
            this.txtRemoteDir.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remote Directory:";
            // 
            // txtRemoteServer
            // 
            this.txtRemoteServer.Location = new System.Drawing.Point(159, 84);
            this.txtRemoteServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemoteServer.Name = "txtRemoteServer";
            this.txtRemoteServer.Size = new System.Drawing.Size(800, 22);
            this.txtRemoteServer.TabIndex = 20;
            this.txtRemoteServer.Text = "jugendfeuerwehrlager.de";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Remote Server:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(148, 337);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 247);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "SearchDuration1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(671, 247);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "SearchDuration2:";
            // 
            // lblDuration1
            // 
            this.lblDuration1.AutoSize = true;
            this.lblDuration1.Location = new System.Drawing.Point(525, 247);
            this.lblDuration1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration1.Name = "lblDuration1";
            this.lblDuration1.Size = new System.Drawing.Size(16, 17);
            this.lblDuration1.TabIndex = 24;
            this.lblDuration1.Text = "0";
            // 
            // lblDuration2
            // 
            this.lblDuration2.AutoSize = true;
            this.lblDuration2.Location = new System.Drawing.Point(799, 247);
            this.lblDuration2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration2.Name = "lblDuration2";
            this.lblDuration2.Size = new System.Drawing.Size(16, 17);
            this.lblDuration2.TabIndex = 25;
            this.lblDuration2.Text = "0";
            // 
            // txtImageUploadWidth
            // 
            this.txtImageUploadWidth.Location = new System.Drawing.Point(159, 212);
            this.txtImageUploadWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImageUploadWidth.Name = "txtImageUploadWidth";
            this.txtImageUploadWidth.Size = new System.Drawing.Size(800, 22);
            this.txtImageUploadWidth.TabIndex = 26;
            this.txtImageUploadWidth.Text = "1024";
            // 
            // labelUploadImageWidth
            // 
            this.labelUploadImageWidth.AutoSize = true;
            this.labelUploadImageWidth.Location = new System.Drawing.Point(16, 215);
            this.labelUploadImageWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUploadImageWidth.Name = "labelUploadImageWidth";
            this.labelUploadImageWidth.Size = new System.Drawing.Size(139, 17);
            this.labelUploadImageWidth.TabIndex = 27;
            this.labelUploadImageWidth.Text = "Upload Image Width:";
            this.labelUploadImageWidth.Click += new System.EventHandler(this.label13_Click);
            // 
            // tipUploadImageWidth
            // 
            this.tipUploadImageWidth.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipUploadImageWidth.Popup += new System.Windows.Forms.PopupEventHandler(this.tipUploadImageWidth_Popup);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 395);
            this.Controls.Add(this.labelUploadImageWidth);
            this.Controls.Add(this.txtImageUploadWidth);
            this.Controls.Add(this.lblDuration2);
            this.Controls.Add(this.lblDuration1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtRemoteServer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemoteDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtRemoteFile2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRemoteFile1);
            this.Controls.Add(this.txtLocalDir2);
            this.Controls.Add(this.txtLocalDir1);
            this.Controls.Add(this.lblLastUpload);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Cam FTP Uploader";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer uploadTimer;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblLastUpload;
        private System.Windows.Forms.TextBox txtLocalDir1;
        private System.Windows.Forms.TextBox txtLocalDir2;
        private System.Windows.Forms.TextBox txtRemoteFile1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemoteFile2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemoteDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemoteServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDuration1;
        private System.Windows.Forms.Label lblDuration2;
        private System.Windows.Forms.TextBox txtImageUploadWidth;
        private System.Windows.Forms.Label labelUploadImageWidth;
        private System.Windows.Forms.ToolTip tipUploadImageWidth;
    }
}

