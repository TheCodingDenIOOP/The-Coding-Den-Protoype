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
    public partial class ActiveClubsReport : Form
    {
        SqlConnection conn;
        public ActiveClubsReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiveClubsReport_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
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
        }

        private void lstClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
