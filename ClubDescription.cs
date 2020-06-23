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
using System.Runtime.Remoting.Messaging;

namespace Secretary
{
    

    public partial class ClubDescription : Form
    {
        SqlConnection SQLCON;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection conn;

        public ClubDescription()
        {
            InitializeComponent();
        }

        private void ClubDescription_Load(object sender, EventArgs e)
        {
            //Setup autocomplete for txtClub textbox
            SQLCON = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            string sql = "Select ClubName From Clubs";

            SQLCON.Open();

            cmd = new SqlCommand(sql, SQLCON);
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            dr = cmd.ExecuteReader();//execute the reader
            while (dr.Read()) //if record is found
            { 
                autotext.Add(dr.GetString(0));
            }
            txtClub.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtClub.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtClub.AutoCompleteCustomSource = autotext;
            SQLCON.Close();

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
            //To update the description
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string query = "update Clubs set Description = '" + textBox3.Text + "'  WHERE ClubName = '" + txtClub.Text + "'";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Club Info Updated Successfully!");
            this.Close();
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SQLCON = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
            SQLCON.Open();

            string NewDesc = textBox3.Text;
            string des = "INSERT INTO Clubs(Description); VALUES (@ND);";
            SqlCommand CMD = new SqlCommand(des, SQLCON);
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
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");

            string sql = "Select ClubName, Description From Clubs Where ClubName=@cn";

            SQLCON.Open();

            cmd = new SqlCommand(sql, SQLCON);
            cmd.Parameters.AddWithValue("@cn", txtClub.Text); //define the parameter name
            dr = cmd.ExecuteReader();//execute the reader
            if (dr.HasRows) //if record is found
            {
                dr.Read();
                txtClub.Text = dr["ClubName"].ToString();
                textBox2.Text = dr["Description"].ToString();
            }

            SQLCON.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            txtClub.Clear();
        }
    }
}