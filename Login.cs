using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Secretary;
using WindowsFormsApp2;

namespace Login
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPw.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True;" +
                " Connect Timeout = 30");
            
            string strSQL = "SELECT * FROM Users WHERE Username = '" + txtUsername.Text + "'" +
                " AND Password = '" + txtPw.Text + "'";

            conn.Open(); 
            
            //create command object
            cmd = new SqlCommand(strSQL, conn);
            //execite the sql command and store the result in the reader
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                if (dr["Role"].Equals("Admin"))
                {
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                    this.Hide();
                }
                else if (dr["Role"].Equals("Secretary"))
                {
                    WeeklyReport wr = new WeeklyReport();
                    wr.Show();
                    this.Hide();
                }
                else if (dr["Role"].Equals("Student"))
                {
                    Search sr = new Search();
                    sr.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Log in failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            dr.Close();
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}