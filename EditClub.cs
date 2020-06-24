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
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
        Dashboard dsh = new Dashboard();
       
        public EditClub(string Str_Value)
        {
            InitializeComponent();
            txtClubName.Text = Str_Value;
        }

        private void EditClub_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader reader;

            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            string strSQL = "SELECT * FROM Clubs WHERE ClubName = '" + txtClubName.Text + "'";
            cmd = new SqlCommand(strSQL, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtClubID.Text = reader["ClubID"].ToString();
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
            Controller ctrl = new Controller();
            int status = ctrl.EditClub(txtClubName.Text, txtPresident.Text, txtVPresident.Text, txtSecretary.Text);

            if (status == 1)
            {
                MessageBox.Show("Club Updated Successfully!");
                dsh.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string query = "update Clubs set President = '" + txtPresident.Text + "', VicePresident = '" + txtVPresident.Text + "', Secretary = '" + txtSecretary.Text + "' WHERE ClubName = '" + txtClubName.Text + "'";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club Info Updated Successfully!");
            dsh.Show();
            this.Close();
            conn.Close();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsh.Show();
            this.Close();
        }
    }
    
}
