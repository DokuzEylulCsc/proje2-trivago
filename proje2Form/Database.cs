using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace proje2Form
{
    static class Database
    {
        public static SQLiteConnection sqlConnection;
        public static SQLiteDataReader sqlDataReader;
        public static SQLiteCommand sqlCommand = new SQLiteCommand();

        public static bool CreateHotel()
        {
            return false;
        }
    }
}
