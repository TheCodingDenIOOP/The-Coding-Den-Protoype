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

        public int RegClub(string clubname, string president, string Vpresident, string secretary, string regDate, string description)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into Clubs (ClubName, President, VicePresident, Secretary, RegistrationDate, Description, Status) values(@clubname, @president, @Vpresident, @secretary, @regDate, @description, 'Active')", conn);
            cmd.Parameters.AddWithValue("@clubname", clubname);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@president", president);
            cmd.Parameters.AddWithValue("@Vpresident", Vpresident);
            cmd.Parameters.AddWithValue("@secretary", secretary);
            cmd.Parameters.AddWithValue("@regDate", regDate);
            
            int status = cmd.ExecuteNonQuery();
            conn.Close();
            return status;
        }

        public int EditClub(string clubname, string president, string Vpresident, string secretary)
        {
            Connect();
            string insertSQL = "update Clubs set President = @president, VicePresident = @Vpresident, Secretary = @secretary WHERE ClubName = @clubname";

            SqlCommand cmd = new SqlCommand(insertSQL, conn);

            cmd.Parameters.AddWithValue("@clubname", clubname);
            cmd.Parameters.AddWithValue("@president", president);
            cmd.Parameters.AddWithValue("@Vpresident", Vpresident);
            cmd.Parameters.AddWithValue("@secretary", secretary);

            int status = cmd.ExecuteNonQuery();
            conn.Close();
            return status;
        }
    }
}
