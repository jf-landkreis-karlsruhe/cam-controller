using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamImageDownloader
{
    public partial class Form1 : Form
    {
        private int duration;
        private string sourcePicUrl;
        private string destinationFolder;
        private int counter;
        WebClient client;

        public Form1()
        {
            InitializeComponent();            
            counter = 0;
            client = new WebClient();
        }


        private void DownloadFileFromURL()
        {
            string imageFileName;
            
            imageFileName = "img" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            imageFileName = DateTime.Now.Year.ToString("D4") + DateTime.Now.Month.ToString("D2") + DateTime.Now.Day.ToString("D2")
                + DateTime.Now.Hour.ToString("D2") + DateTime.Now.Minute.ToString("D2") + DateTime.Now.Second.ToString("D2");            
            imageFileName = imageFileName + ".jpg";
            imageFileName = Path.Combine(destinationFolder, imageFileName);

            try
            {                
                client.DownloadFile(sourcePicUrl, imageFileName);
                lblStatus.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString() + " --- Download erfolgreich! --- " + imageFileName;
                picBox.Image = Image.FromFile(imageFileName); 
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            duration = Convert.ToInt32(txtDuration.Text);
            sourcePicUrl = txtSourceURL.Text;
            destinationFolder = txtDestinationFolder.Text;

            if (destinationFolder != String.Empty && sourcePicUrl != String.Empty)
            {
                counter = 0;
                downloadTimer.Enabled = true;
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                picBox.Focus();
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            downloadTimer.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }


        private void downloadTimer_Tick(object sender, EventArgs e)
        {
            if (counter >= duration)
            {
                counter = 0;
                DownloadFileFromURL();
            }
            else
            {
                counter++;
            }
        }

    }
}
