using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private string getHTML(string url)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(url);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //string htmlSrc = getHTML(tbUrl.Text);
            // rtbSrccode = 
            if (!tbUrl.Text.StartsWith("http"))
            {
                MessageBox.Show("Url không hợp lệ!");
                return;
            }
            WebClient myCl = new WebClient();
            Stream res = myCl.OpenRead(tbUrl.Text);
            string download = "";
            if (!tbPath.Text.EndsWith("html"))
            {
                download = tbPath.Text+ "\\" + "download.html";
            }
            else download = tbPath.Text;
            myCl.DownloadFile(tbUrl.Text, download);
            using (StreamReader reader = new StreamReader(res))
            {
                string mess = "";
                rtbSrccode.Text = reader.ReadToEnd();
                if (!tbPath.Text.Contains(":\\"))
                {
                    mess = Application.ExecutablePath + "\\" + download + " Download thành công vô folder!";
                }
                else { mess = download + " Download thành công vô folder!"; }
                MessageBox.Show(mess);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
