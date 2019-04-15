using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.New.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic.New
{
    public class HistoryManager
    {
        public static void AddHistory(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Name, item.Date);
        }

        public static List<HistoryItem> GetHistory()
        {
            var adapter = new HistoryTableAdapter();
            var result = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Name = row.Name;
                item.Date = row.Date;

                result.Add(item);
            }
            return result;

        }
        public static string UrlToName(string URL)
        {
            string [] name = URL.Split('.');
            return name[1];
        }
    }
}
