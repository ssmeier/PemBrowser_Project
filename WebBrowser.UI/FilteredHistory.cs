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
    public partial class FilteredHistory : Form
    {
        public FilteredHistory()
        {
            InitializeComponent();
        }

        public string term;
        

        private void FilteredHistoryBox_Load(object sender, EventArgs e)
        {
            termLabel.Text = String.Format("Results for {0}", term);
            var list = HistoryManager.filterHistory(term);
            foreach (var item in list)
            {
                searchResults.Items.Add(item);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void termLabel_Click(object sender, EventArgs e)
        {

        }
    
    }
}
