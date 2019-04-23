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

        }

        public string term;
             
        private void FilteredHistoryBox_Load(object sender, EventArgs e)
        {
          var list = HistoryManager.filterHistory(term);
          foreach(var item in list)
            {
                searchResults.Items.Add(term);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
