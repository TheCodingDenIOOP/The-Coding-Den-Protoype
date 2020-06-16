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
    public partial class ClubActivitiesReport : Form
    {
        SqlConnection conn;
        public ClubActivitiesReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClubActivitiesReport_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\WeeklyReport.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            string strSQL = "SELECT Activities FROM Club WHERE ClubName=@id;";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader;



            conn.Open();
            reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                lstActivities.Items.Add(reader["Activities"].ToString());
            }
            conn.Close();
        }
    }
}
