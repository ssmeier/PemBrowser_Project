using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Data.New.BookmarksDataSetTableAdapters;
using WebBrowser.Logic.New;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerUI : Form
    {
        public BookmarkManagerUI()
        {
            InitializeComponent();
        }

        private void BookmarkManagerUI_Load(object sender, EventArgs e)
        {
            var bookmarks = BookmarkManager.GetBookmarks();
            foreach (var item in bookmarks)
            {
                string BookmarkItem = String.Format("{0} ({1}) ", item.Name, item.URL);
                listBox1.Items.Add(BookmarkItem);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var adapter = new TableTableAdapter();
            var BookmarkList = adapter.GetData();
            foreach(var item in listBox1.SelectedItems)
            {
                        
            }
        }
    }
}
