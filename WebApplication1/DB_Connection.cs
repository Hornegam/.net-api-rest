using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WebApplication1
{
    public class DB_Connection
    {
        public SqliteConnection Connection()
        {
            return new SqliteConnection("Data Source=db.sqlite");
        }
    }
}
