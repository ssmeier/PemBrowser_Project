using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class ToolBrowserControl : UserControl
    {
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


    }
}
