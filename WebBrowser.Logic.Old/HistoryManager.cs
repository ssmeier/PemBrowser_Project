using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class HistoryManager
    {
        public static void addHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Name);

        }
    }
}
