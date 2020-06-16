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

namespace Secretary
{
    

    public partial class ClubDescription : Form
    {
        SqlConnection SQLCON;
        SqlCommand cmd;
        SqlDataReader dr;


        public ClubDescription()
        {
            InitializeComponent();
        }

        private void ClubDescription_Load(object sender, EventArgs e)
        {

        }

        private void ClubDescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cLUBREPRESENTATIVESECRETARYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEWEEKLYREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeeklyReport ua = new WeeklyReport();
            ua.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SQLCON = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\DataGrid.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            SQLCON.Open();

            string NewDesc = textBox3.Text;
            string Seulgi = "INSERT INTO ClubDesc(NewDes); VALUES (@ND);";
            SqlCommand CMD = new SqlCommand(Seulgi, SQLCON);
            CMD.Parameters.AddWithValue("@ND", NewDesc);
            SQLCON.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ClubDescription login = new ClubDescription();
            login.Show();
            this.Close();
        }

        private void txtClub_TextChanged(object sender, EventArgs e)
        {
            string txt1 = txtClub.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLCON = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\DataGrid.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            string sql = "Select ClubName, CurrentDes From ClubDesc Where ClubName=@cn";

            SQLCON.Open();

            cmd = new SqlCommand(sql, SQLCON);
            cmd.Parameters.AddWithValue("@cn", txtClub.Text); //define the parameter name
            dr = cmd.ExecuteReader();//execute the reader
            if (dr.HasRows) //if record is found
            {
                dr.Read();
                txtClub.Text = dr["ClubName"].ToString();
                textBox2.Text = dr["CurrentDes"].ToString();
            }

            SQLCON.Close();
        }
    }
}