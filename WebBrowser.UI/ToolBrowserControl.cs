using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class ToolBrowserControl : UserControl
    {
        SessionHistory session = new SessionHistory();
        public ToolBrowserControl()
        {
            InitializeComponent();
        }


        private void goButton_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Uri targetUrl = new Uri(urlBox.Text);
                    webBrowser1.Url = targetUrl;
                    
                }
                catch { }
            
        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                goButton_Click(new object(), new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = session.PageForward(webBrowser1.Url);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = session.PageBackward(webBrowser1.Url);

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var currentSession = session.getBackStack();
            var page = webBrowser1.Url;
            webBrowser1.Url = null;
            webBrowser1.Url = page;
            session.setBackStack(currentSession);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            session.addBackStack(webBrowser1.Url);
        }
    }
}
