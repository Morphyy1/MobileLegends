/*using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace TimeTracker
{
    public class DataBase
    {
        private readonly SQLiteConnection conn;

        public DataBase(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Item>();
        }

        public List<Item> GetItems() =>
            conn.Table<Item>().ToList();

        public int SaveItem(Item item) =>
            conn.Insert(item);
    }
}*/