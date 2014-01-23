using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace HrtHttpServer.DB
{
    class DBAccessor
    {
        private string m_strSqlFile;
        private SQLite m_sqlite;
        public DBAccessor()
        {
            m_sqlite = new SQLite(m_strSqlFile);
        }

        public void createDBFile()
        {
           if (!File.Exists(m_strSqlFile))
           {
               SQLiteConnection.CreateFile(m_strSqlFile);
           }
        }
    }
}
