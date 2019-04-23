using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Data.New;
using WebBrowser.Data.New.HistoryDataSetTableAdapters;
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
                string logItem = String.Format("[{0}] | {1} | ({2}) ", log.Date, log.Name, log.URL);
                listBox1.Items.Add(logItem);
            }
         }

        // Search Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                var term = textBox1.Text;
                var searchResult = new FilteredHistory();
                searchResult.term = term;
                searchResult.ShowDialog();
            }
            else { }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            var adapter = new HistoryTableAdapter();
            var history = adapter.GetData();
            foreach(var item in history)
            {
                HistoryManager.DeleteHistoryRow(item);
                listBox1.Items.Clear();
            }
        }
    }
}
