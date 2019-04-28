using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.New;
using WebBrowser.Data.New.BookmarksDataSetTableAdapters;
using static WebBrowser.Data.New.BookmarksDataSet;

namespace WebBrowser.Logic.New
{
    public class BookmarkManager
    {
        public static void UpdateDatabase()
        {
            var adapter = new TableTableAdapter();
            var bookmarkSet = new BookmarksDataSet();
            adapter.Update(bookmarkSet);
        }

        public static void AddBookmark(BookmarkItem item) {
            var adapter = new TableTableAdapter();
            adapter.Insert(item.URL, item.Name);
        }

        public static List<BookmarkItem> GetBookmarkList()
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

        public static TableDataTable GetBookmarkData()
        {
            var adapter = new TableTableAdapter();
            return adapter.GetData();
        }

        public static void DeleteBookmarkItem(BookmarkItem item)
        {
            var adapter = new TableTableAdapter();
            adapter.DeleteQuery(item.ID, item.URL, item.Name);
            UpdateDatabase();
        }

        public static void DeleteBookmarkRow(BookmarksDataSet.TableRow item)
        {
            var adapter = new TableTableAdapter();
            adapter.Delete(item.Id, item.URL, item.Name);

        }

        public static BookmarkItem FindBookmark(string term)
        {
            var adapter = new TableTableAdapter();
            var workingList = GetBookmarkList();
            var result = workingList.Find(x => x.Name == term);
            return result;
        }
    }
}
