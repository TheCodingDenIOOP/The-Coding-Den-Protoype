using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class EditClub : Form
    {
        SqlConnection conn;
        Dashboard dsh = new Dashboard();
        public EditClub(string Str_Value)
        {
            InitializeComponent();
            txtClubName.Text = Str_Value;
        }

        private void EditClub_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string strSQL = "SELECT * FROM Clubs WHERE ClubName = '" + txtClubName.Text + "'";
            cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtClubName.Text = reader["ClubName"].ToString();
                txtPresident.Text = reader["President"].ToString();
                txtVPresident.Text = reader["VicePresident"].ToString();
                txtSecretary.Text = reader["Secretary"].ToString();
                txtRgstDate.Text = reader["RegistrationDate"].ToString();
                txtDescription.Text = reader["Description"].ToString();
            }

            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string query = "update Clubs set President = '" + txtPresident.Text + "', VicePresident = '" + txtVPresident.Text + "', Secretary = '" + txtSecretary.Text + "' WHERE ClubName = '" + txtClubName.Text + "'";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club Info Updated Successfully!");
            dsh.Show();
            this.Close();
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsh.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstMembers.Items.Clear();
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            //string strSQL = "SELECT * FROM Clubs";
            string strSQL = "SELECT * FROM Members WHERE (ClubId = ) AND (ClubName LIKE '%" + txtSearch.Text + "%')";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstMembers.Items.Add(reader["ClubName"].ToString());
            }
            conn.Close();
        }
    }
    
}
