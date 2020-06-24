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
    public partial class NewClub : Form
    {
        Dashboard dsh = new Dashboard();
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
        public NewClub()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsh.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Clubs (ClubName, President, VicePresident, " +
                "Secretary, RegistrationDate, Description, Status) values('" + txtClubName.Text + "'," +
                "'" + txtPresident.Text + "', '" + txtVPresident.Text + "', '" + txtSecretary.Text + "'" +
                ",'" + txtRgstDate.Text + "','" + txtDescription.Text + "', 'Active')";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club Registered Successfully!");
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Close();

            conn.Close();
        }

        private void NewClub_Load(object sender, EventArgs e)
        {

        }
    }
}