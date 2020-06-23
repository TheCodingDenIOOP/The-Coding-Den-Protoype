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
    public partial class AddMember : Form
    {
        SqlConnection conn;
        public AddMember(string Str_Value)
        {
            InitializeComponent();
            txtClubID.Text = Str_Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ClubID = int.Parse(txtClubID.Text);
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ClubID", ClubID);
            cmd.CommandText = "INSERT INTO Members (ClubID, MemberName, Position) values (@ClubID,' + txtName.Text + ', 'Member')";
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Member Added Successfully!");
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
