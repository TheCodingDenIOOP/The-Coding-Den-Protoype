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
    public partial class Archived : Form
    {
        SqlConnection conn;
        public Archived()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Close();
        }

        private void Archived_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            string strSQL = "SELECT * FROM Clubs WHERE Status = 'Archived'";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstClub.Items.Add(reader["ClubName"].ToString());
            }
            conn.Close();

            try
            {
                lstClub.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstClub.Items.Clear();
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            //string strSQL = "SELECT * FROM Clubs";
            string strSQL = "SELECT * FROM Clubs WHERE (ClubName LIKE '%" + txtSearch.Text + "%') AND (Status = 'Archived')";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstClub.Items.Add(reader["ClubName"].ToString());
            }
            conn.Close();

            try
            {
                lstClub.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string CName = lstClub.GetItemText(lstClub.SelectedItem);
            cmd.Parameters.AddWithValue("@cname", CName);
            string query = "update Clubs set Status = 'Active' WHERE ClubName = @CName";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club activated successfully!");

            //Refresh lstClub
            lstClub.Items.Clear();

            string strSQL = "SELECT * FROM Clubs WHERE Status = 'Archived'";
            cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstClub.Items.Add(reader["ClubName"].ToString());
            }
            conn.Close();

            try
            {
                lstClub.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string CName = lstClub.GetItemText(lstClub.SelectedItem);
            cmd.Parameters.AddWithValue("@cname", CName);
            string query = "delete from Clubs WHERE ClubName = @CName";
            cmd.CommandText = query;

            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to delete this club?","Delete Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Club Activated Successfully!");
            }

            //Refresh lstClub
            lstClub.Items.Clear();

            string strSQL = "SELECT * FROM Clubs WHERE Status = 'Archived'";
            cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstClub.Items.Add(reader["ClubName"].ToString());
            }
            conn.Close();

            try
            {
                lstClub.SelectedIndex = 0;
            }
            catch { }

            conn.Close();
        }

        private void lstClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
