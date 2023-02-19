using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Testpedia
{
    public class Connect
    {
       public static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\orcue\\source\\repos\\Testpedia\\TestPediaDB.db;Version=3;");
    }
}
