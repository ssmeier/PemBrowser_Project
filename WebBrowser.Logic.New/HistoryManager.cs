using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.New;
using WebBrowser.Data.New.HistoryDataSetTableAdapters;
using static WebBrowser.Data.New.HistoryDataSet;

namespace WebBrowser.Logic.New
{
    public class HistoryManager
    {
        public static void UpdateDatabase()
        {
            var adapter = new HistoryTableAdapter();
            var historySet = new HistoryDataSet();
            adapter.Update(historySet);
        }
        public static void AddHistory(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Name, item.Date);
        }

        public static void DeleteHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            var oldItem = item;
            adapter.Delete(item.ID, item.URL, item.Name, item.Date);
            adapter.UpdateQuery(item.URL, item.Name, item.Date, oldItem.ID, oldItem.URL, oldItem.Name, oldItem.Date, item.ID);
        }

        public static void DeleteHistoryRow(HistoryDataSet.HistoryRow item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Delete(item.Id, item.URL, item.Name, item.Date);
            
        }

        public static List<HistoryItem> GetHistoryList()
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

        public static HistoryDataTable GetHistoryData()
        {
            var adapter = new HistoryTableAdapter();
            return adapter.GetData();
        }

        public static List<string> filterHistory(string term)
        {
            var history = HistoryManager.GetHistoryList();
            var result = new List<string>();
            foreach (var log in history)
            {
                if (log.Name.ToLower().Contains(term.ToLower()) || log.URL.ToLower().Contains(term.ToLower()))
                {
                    string logItem = String.Format("[{0}] | {1} | ({2}) ", log.Date, log.Name, log.URL);
                    result.Add(logItem);
                }

            }
            return result;
        }

        public static string UrlToName(string URL)
        {
            string [] name = URL.Split('.');
            return name[1];
        }

        

        public static HistoryItem FindHistoryItem(string term)
        {
            var adapter = new HistoryTableAdapter();
            var workingList = GetHistoryList();
            return workingList.Find(x => x.Name == term);
        }
    }
}
