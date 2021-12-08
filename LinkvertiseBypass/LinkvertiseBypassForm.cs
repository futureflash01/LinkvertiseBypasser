using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace LinkvertiseBypass
{
    public partial class LinkvertiseBypassForm : Form
    {
        public LinkvertiseBypassForm()
        {
            InitializeComponent();
        }

        public class ReadOnlyTextBox : TextBox
        {
            [DllImport("user32.dll")]
            static extern bool HideCaret(IntPtr hWnd);

            public ReadOnlyTextBox()
            {
                this.ReadOnly = true;
                this.BackColor = Color.White;
                this.GotFocus += TextBoxGotFocus;
                this.Cursor = Cursors.Arrow; // mouse cursor like in other controls
            }

            private void TextBoxGotFocus(object sender, EventArgs args)
            {
                HideCaret(this.Handle);
            }
        }

        private void bypassButton_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.bypass.vip");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    url = linkTextBox.Text
                });

                streamWriter.Write(json);
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic final = JObject.Parse(result);
                    bypassedTextBox.Text = final.destination;
                    if (result.ToString().Contains("null"))
                    {
                        MessageBox.Show("The Linkvertise link you provided is a newer version and cannot be bypassed at the moment. As soon as someone figures out a solution, I will be sure to implement it", "Link is a Newer Version", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bypassedTextBox.Clear();
                        copyButton.Enabled = false;
                    }
                    else
                    {
                        copyButton.Enabled = true;
                    }
                }
            }
            catch (WebException Error)
            {
                if (Error.ToString().Contains("422") || (Error.ToString().Contains("400")))
                {
                    MessageBox.Show("Link is invalid or Linkvertise is ratelimiting your requests at the moment. If this error keeps showing, please wait 10 minutes and try again. Also make sure the link you're trying to bypass is spelled correctly", "Invalid Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bypassedTextBox.Clear();
                    copyButton.Enabled = false;
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(bypassedTextBox.Text);
        }

        private void LinkvertiseBypassForm_Load(object sender, EventArgs e)
        {
            copyButton.Enabled = false;
        }
    }
}
