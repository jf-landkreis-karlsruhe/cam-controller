using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CamFtpUpload
{
    public partial class frmMain : Form
    {
        private string localDir1;
        private string localDir2;
        private string remoteDir;
        private string remoteServer;
        private string remoteFile1;
        private string remoteFile2;
        private string userName;
        private string password;
        private bool isRunning;

        private FTPClient ftpClient;

        public frmMain()
        {
            InitializeComponent();
            isRunning = false;
            uploadTimer.Interval = Convert.ToInt32(numericUpDown1.Value * 60 * 1000);            
        }


        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                txtLocalDir1.Enabled = true;
                txtLocalDir2.Enabled = true;
                txtRemoteDir.Enabled = true;
                txtRemoteServer.Enabled = true;
                txtRemoteFile1.Enabled = true;
                txtRemoteFile2.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;

                uploadTimer.Enabled = false;
                isRunning = false;
                btnStartStop.Text = "Start";
            }
            else
            {
                localDir1 = txtLocalDir1.Text;
                localDir2 = txtLocalDir2.Text;
                remoteDir = txtRemoteDir.Text;
                remoteServer = txtRemoteServer.Text;
                remoteFile1 = txtRemoteFile1.Text;
                remoteFile2 = txtRemoteFile2.Text;
                userName = txtUserName.Text;
                password = txtPassword.Text;

                txtLocalDir1.Enabled = false;
                txtLocalDir2.Enabled = false;
                txtRemoteDir.Enabled = false;
                txtRemoteServer.Enabled = false;
                txtRemoteFile1.Enabled = false;
                txtRemoteFile2.Enabled = false;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;

                uploadTimer.Enabled = true;
                isRunning = true;
                btnStartStop.Text = "Stop";

                if (!StartFtp())
                {
                    btnStartStop_Click(sender, e);
                }
            }
        }


        private bool StartFtp()
        {
            bool successFlag;
            successFlag = false;

            try
            {
                ftpClient = new FTPClient(remoteServer, userName, password);
                if (ftpClient != null)
                {                    
                    successFlag = true;
                }
            }
            catch
            {
                successFlag = false;
            }

            return successFlag;
        }


        private void StopFtp()
        {
            ftpClient = null;
        }


        private bool GetNewestFileInDir(string directory, out FileInfo newestFileInfo)
        {
            bool hasFiles;
            DirectoryInfo dirInfo;            

            newestFileInfo = null;
            hasFiles = false;

            if (directory != String.Empty)
            { 
                dirInfo = new DirectoryInfo(directory);
                //if (dirInfo.GetFiles().Count() > 1)
                if (dirInfo.EnumerateFiles().Count() > 1)
                {
                    //newestFileInfo = dirInfo.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                    newestFileInfo = dirInfo.EnumerateFiles().OrderByDescending(f => f.LastWriteTime).ElementAt(1);
                    hasFiles = true;
                }
                else
                {
                    newestFileInfo = null;
                    hasFiles = false;
                }
            }
            return hasFiles;
        }


        private bool UploadFiles()
        {
            bool successFlag;
            FileInfo newestFile1;
            FileInfo newestFile2;
            DateTime startTime;

            successFlag = false;

            try
            {
                startTime = DateTime.Now;
                if (GetNewestFileInDir(localDir1, out newestFile1))
                {
                    lblDuration1.Text = (DateTime.Now - startTime).TotalSeconds.ToString();
                    ftpClient.UploadFile(remoteDir, remoteFile1, newestFile1);
                }

                startTime = DateTime.Now;
                if (GetNewestFileInDir(localDir2, out newestFile2))
                {
                    lblDuration2.Text = (DateTime.Now - startTime).TotalSeconds.ToString();
                    ftpClient.UploadFile(remoteDir, remoteFile2, newestFile2);
                }
                                              
                successFlag = true;
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
                successFlag = false;
            }

            return successFlag;
        }


        private void uploadTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime;
            currentTime = DateTime.Now;

            StartFtp();

            if (ftpClient != null)
            {
                try
                {
                    //ftpClient.CheckConnection();

                    if (UploadFiles())
                    {
                        lblLastUpload.ForeColor = Color.Green;
                        lblLastUpload.Text = "Last successful upload: " + currentTime.ToLongDateString() + " " + currentTime.ToLongTimeString();
                    }
                    else
                    {
                        lblLastUpload.ForeColor = Color.Red;
                        lblLastUpload.Text = "UPLOAD ERROR: " + currentTime.ToLongDateString() + " " + currentTime.ToLongTimeString();
                    }
                }
                catch(Exception ex)
                {
                    lblLastUpload.ForeColor = Color.Red;
                    lblLastUpload.Text = "UPLOAD EXCEPTION: " + ex.Message + " " + currentTime.ToLongDateString() + " " + currentTime.ToLongTimeString();
                }                
            }            
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            uploadTimer.Enabled = false;
            uploadTimer.Interval = Convert.ToInt32(numericUpDown1.Value * 60 * 1000);
            uploadTimer.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
