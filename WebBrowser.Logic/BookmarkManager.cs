using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data.Database1DataSetTableAdapters;

namespace WebBrowser.Logic
{
    class BookmarkManager
    {
        public static void addBookmark(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Name);


        }
    }
}
