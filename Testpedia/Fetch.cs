using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testpedia
{
    public class Fetch
    {
       static DataTable dt;
        public static DataTable Getdata(string sql)
        {
            dt =new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql,Connect.connection);
            adapter.Fill(dt);
            return dt;
        }
    }
}
