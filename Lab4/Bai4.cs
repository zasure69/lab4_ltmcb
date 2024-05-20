using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Security.Policy;
using System.Net.Http;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            
        }
        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
            SuppressScriptErrors();
            string url = tbUrl.Text;
            if (url.Length != 0)
            {
                webBrowser1.Navigate(url);
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            

        }
        string Path1;

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string url = tbUrl.Text;
                    Path1 = ofd.SelectedPath + "/download.html";
                    string Path2 = ofd.SelectedPath + "\\resources";
                    if (!Directory.Exists(Path2))
                    {
                        Directory.CreateDirectory(Path2);
                    }
                    WebClient myCl = new WebClient();
                    Stream res = myCl.OpenRead(tbUrl.Text);

                    //var fileNodes = doc.DocumentNode.SelectNodes();

                    myCl.Encoding = System.Text.Encoding.UTF8;
                    myCl.DownloadFile(url, Path1);

                    // Tạo một đối tượng HtmlDocument từ nội dung HTML
                    HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                    htmlDocument.LoadHtml(webBrowser1.DocumentText);

                    // Tìm và xử lý tất cả các thẻ <link> để tải xuống các tệp CSS
                    HtmlNodeCollection linkNodes = htmlDocument.DocumentNode.SelectNodes("//link[@rel='stylesheet']");
                    if (linkNodes != null)
                    {
                        foreach (HtmlNode linkNode in linkNodes)
                        {
                            string hrefUrl = linkNode.GetAttributeValue("href", "");
                            if (!string.IsNullOrWhiteSpace(hrefUrl))
                            {
                                string fileName = Path.GetFileName(hrefUrl);
                                fileName = string.Join("", fileName.Split(Path.GetInvalidFileNameChars()));
                                string fileUrl = new Uri(new Uri(url), hrefUrl).AbsoluteUri;
                                myCl.DownloadFile(fileUrl, Path2 + "/" + fileName);
                            }
                        }
                    }

                    // Tìm và xử lý tất cả các thẻ <link> để tải xuống các tệp Script
                    HtmlNodeCollection linkNodes2 = htmlDocument.DocumentNode.SelectNodes("//script[@src]");
                    if (linkNodes2 != null)
                    {
                        foreach (HtmlNode linkNode in linkNodes2)
                        {
                            string srcUrl = linkNode.GetAttributeValue("src", "");
                            if (!string.IsNullOrWhiteSpace(srcUrl))
                            {
                                string fileName = Path.GetFileName(srcUrl);
                                fileName = string.Join("", fileName.Split(Path.GetInvalidFileNameChars())); 
                                
                                string fileUrl = new Uri(new Uri(url), srcUrl).AbsoluteUri;
                                myCl.DownloadFile(fileUrl, Path2 + "/" + fileName);
                            }
                        }
                    }

                    // Tìm và xử lý tất cả các thẻ <link> để tải xuống các tệp Image
                    HtmlNodeCollection linkNodes3 = htmlDocument.DocumentNode.SelectNodes("//img[@src]");
                    if (linkNodes3 != null)
                    {
                        foreach (HtmlNode linkNode in linkNodes3)
                        {
                            string srcUrl = linkNode.GetAttributeValue("src", "");
                            if (!string.IsNullOrWhiteSpace(srcUrl))
                            {
                                string fileName = Path.GetFileName(srcUrl);
                                fileName = string.Join("", fileName.Split(Path.GetInvalidFileNameChars()));
                                string fileUrl = new Uri(new Uri(url), srcUrl).AbsoluteUri;
                                myCl.DownloadFile(fileUrl, Path2 + "/" + fileName);
                            }
                        }
                    }

                    // Tìm và xử lý tất cả các thẻ <link> để tải xuống các tệp Image
                    HtmlNodeCollection linkNodes4 = htmlDocument.DocumentNode.SelectNodes("//a[@href]");
                    if (linkNodes4 != null)
                    {
                        foreach (HtmlNode linkNode in linkNodes4)
                        {
                            string hrefUrl = linkNode.GetAttributeValue("href", "");
                            if (!string.IsNullOrWhiteSpace(hrefUrl) && hrefUrl.EndsWith(".*"))
                            {
                                string fileName = Path.GetFileName(hrefUrl);
                                fileName = string.Join("", fileName.Split(Path.GetInvalidFileNameChars()));
                                string fileUrl = new Uri(new Uri(url), hrefUrl).AbsoluteUri;
                                if (fileUrl.StartsWith("http") || fileUrl.StartsWith("https"))
                                    myCl.DownloadFile(fileUrl, Path2 + "/" + fileName);
                            }
                        }
                    }

                    MessageBox.Show("Source File đã tải xong!");
                }
            }
                
        }
        private void btnPageSrc_Click(object sender, EventArgs e)
        {
            rtbSrc.BringToFront();
            rtbSrc.Text = webBrowser1.DocumentText;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }
        private void SuppressScriptErrors()
        {
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Window.Error += new HtmlElementErrorEventHandler(scriptWindow_Error);
            }
        }

        private void scriptWindow_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            SuppressScriptErrors();
            tbUrl.Text = webBrowser1.Url.ToString();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
