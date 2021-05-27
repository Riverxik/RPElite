using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace RPElite
{
    class Database
    {
        private static SQLiteConnection connection;
        public static SQLiteConnection GetConnection() { 
            if (connection == null) { new Database(); }
            return connection; 
        }
        private Database()
        {
            connection = new SQLiteConnection(@"DataSource=RPElite.db; Version=3;");
        }

        public static void Init()
        {
            DatabaseFileCheck();
        }

        private static void DatabaseFileCheck()
        {
            if (!File.Exists(@"RPElite.db"))
            {
                SQLiteConnection.CreateFile(@"RPElite.db");
            }
        }
    }
}
