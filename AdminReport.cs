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
    public partial class AdminReport : Form
    {
        SqlConnection func;
        SqlDataAdapter da;

        public AdminReport()
        {
            InitializeComponent();
        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            func = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TestDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ReportId,ClubName, ReportDate, Activities FROM WeeklyReport";



            func.Open();



            //Creat data adapter
            da = new SqlDataAdapter(sql, func);



            //instantiate the dataset
            DataSet ds = new DataSet();
            da.Fill(ds, "WeeklyReport");//fill the dataset with the records from the sql query



            //display the records on the datagridview
            dgv.DataSource = ds.Tables["WeeklyReport"];
            func.Close();
        }
    }
    
}
