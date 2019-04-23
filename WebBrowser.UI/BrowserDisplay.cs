using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic.New;

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
    
        private void toolBrowserControl1_Load(object sender, EventArgs e)
        {

        }

        private void urlBox_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new TabPage();
            x.Text = "New Tab";
            var y = new ToolBrowserControl();
            y.Dock = DockStyle.Fill;
            
            tabField.TabPages.Add(x);
            x.Controls.Add(y);
            

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabField.TabPages.Count > 1)
            {
                tabField.TabPages.Remove(tabField.SelectedTab);
            }
            else { };
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var history = new HistoryManagerUI();
            history.ShowDialog();
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var bookmarks = new BookmarkManagerUI();
                bookmarks.ShowDialog();
            }
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var history = HistoryManager.GetHistoryList();
            foreach (var item in history)
            {
                HistoryManager.DeleteHistoryItem(item);
            }
        }
    }
}
