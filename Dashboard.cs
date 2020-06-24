using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2;

namespace Login
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM Clubs WHERE Status = 'Active'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            LI login = new LI();
            login.Show();
            this.Close();
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            NewClub nc = new NewClub();
            nc.Show();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
                string ClubName = lstClub.GetItemText(lstClub.SelectedItem);
                EditClub ec = new EditClub(ClubName);
                ec.Show();
                this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstClub.Items.Clear();
            string strSQL = "SELECT * FROM Clubs WHERE (ClubName LIKE '%" + txtSearch.Text + "%') AND (Status = 'Active')";
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

        private void btnArchived_Click(object sender, EventArgs e)
        {
            Archived ar = new Archived();
            ar.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string CName = lstClub.GetItemText(lstClub.SelectedItem);
            cmd.Parameters.AddWithValue("@cname", CName);
            string query = "update Clubs set Status = 'Archived' WHERE ClubName = @CName";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club removed successfully!");

            lstClub.Items.Clear();

            string strSQL = "SELECT * FROM Clubs WHERE Status = 'Active'";
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

        private void btnActiveClub_Click(object sender, EventArgs e)
        {
            ActiveClubsReport acr = new ActiveClubsReport();
            acr.Show();
        }

       private void btnClubAct_Click(object sender, EventArgs e)
        {
           /* SelectDate sd = new SelectDate();
            sd.Show();
            this.Close(); */
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClublist_Click(object sender, EventArgs e)
        {

        }

        private void lstClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSIF_Click(object sender, EventArgs e)
        {

        }
    }
}
