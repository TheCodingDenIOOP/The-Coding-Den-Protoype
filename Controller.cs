using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login
{
    class Controller
    {
        SqlConnection conn;

        public void Connect()
        {
            conn =  new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            //check connection
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
