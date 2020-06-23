using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data;

namespace WindowsFormsApp2
{   


    public partial class CD : Form
    {
        SqlConnection SQLCON;
        SqlCommand cmd;
        SqlDataReader dr;

        public CD()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textS.Text = "Attention!Only FULL NAME allowed!";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                SQLCON = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TestDB.mdf;Integrated Security=True;Connect Timeout=30");

                string sql = "Select ClubName, President, VicePresident, RegistrationDate, Description, Status From Clubs Where ClubName=@textS";

                SQLCON.Open();

                cmd = new SqlCommand(sql, SQLCON);
                cmd.Parameters.AddWithValue("@textS", textS.Text); //define the parameter name
                dr = cmd.ExecuteReader();//execute the reader
                if (dr.HasRows) //if record is found
                {
                    dr.Read();
                    lblCN.Text = dr["ClubName"].ToString();
                    lblPS.Text = dr["President"].ToString();
                    lblRG.Text = dr["RegistrationDate"].ToString();
                    lblI.Text = dr["Description"].ToString();
                    lblVP.Text = dr["VicePresident"].ToString();
                    lblSt.Text = dr["Status"].ToString();
                }

                SQLCON.Close();
                dr.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                
            }

        }

        private void lblVP_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Search f2 = new Search();
            f2.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblCN.Text = "";  
            lblPS.Text = "";
            lblRG.Text = "";
            lblI.Text = "";
            lblVP.Text = "";
            lblSt.Text = "";
        }

        private void textS_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            });  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult question;

            question = MessageBox.Show("Do you want to quit the APP?", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Keypress Enter as "search button"
        private void textS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char mykey = (char)e.KeyChar;
            if(mykey==13)
            {
                btnS.PerformClick();
            }
        }
    }
}
