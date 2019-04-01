using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class ViewWindow : Form
    {
        public ViewWindow()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewerScreen_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            String about = "Minibrowser is a lightweight browser " +
                "created as an exercise in the design and development of software." +
                "\n\n" +"created by Sam Meier for Auburn University @sm0043";
            MessageBox.Show(about);
       
        }
          
        
        
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                Uri targetUrl = new Uri(urlBox.Text);
                viewerScreen.Url = targetUrl;
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
