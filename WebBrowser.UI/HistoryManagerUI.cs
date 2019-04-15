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
    public partial class HistoryManagerUI : Form
    {
        public HistoryManagerUI()
        {
            InitializeComponent();
        }

        private void HistoryManagerUI_Load(object sender, EventArgs e)
        {
            var history = HistoryManager.GetHistory();
            foreach(var log in history)
            {
                string logItem = String.Format("[{0}] {1} ({2}) ", log.Date, log.Name, log.URL);
                listBox1.Items.Add(logItem);
            }
         }
    }
}
