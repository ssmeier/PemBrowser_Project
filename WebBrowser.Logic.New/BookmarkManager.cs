using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.New.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic.New
{
    public class BookmarkManager
    {
        public static void AddBookmark(BookmarkItem item) {
            var adapter = new TableTableAdapter();
            adapter.Insert(item.URL, item.Name);
        }

        public static List<BookmarkItem> GetBookmarks()
        {
            var adapter = new TableTableAdapter();
            var result = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach(var row in rows) {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Name = row.Name;

                result.Add(item);
            }
            return result;

        }
    }
}
