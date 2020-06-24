using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public string SignIn(string username, string password)
        {
            string role = "";
            Connect();

            string sql = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);



            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.HasRows)
            {
                dr.Read();
                if (dr["Role"].Equals("Admin"))
                {
                    role = "Admin";
                }
                else if (dr["Role"].Equals("Secretary"))
                {
                    role = "Secretary";
                }
                else if (dr["Role"].Equals("Student"))
                {
                    role = "Student";
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Log in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            conn.Close();

            return role;
        }
    }
}
