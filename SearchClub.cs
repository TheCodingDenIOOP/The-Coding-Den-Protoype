using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace WindowsFormsApp2
{
 
    public partial class Search : Form
    {
        SqlConnection func;
        SqlDataAdapter da;


        public Search()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|'TestDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT ClubId,ClubName, President, Desciption FROM Clubs WHERE ClubName LIKE '%" + textSN.Text + "%'OR ClubId LIKE '%" + textSN.Text + "%'";

            func.Open();

            //Creat data adapter
            da = new SqlDataAdapter(sql, func);

            //instantiate the dataset
            DataSet ds = new DataSet();
            da.Fill(ds, "Clubs");//fill the dataset with the records from the sql query

            //display the records on the datagridview
            dgv.DataSource = ds.Tables["Clubs"];
            func.Close();

        }

        private void LearnMore_Click(object sender, EventArgs e)
        {
            CD f1 = new CD();
            f1.Show();
            this.Hide();

        }

        private void textSN_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }
        
        //Keypress event as "search button"
        private void textSN_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            });
        }
    }
}
