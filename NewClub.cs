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
            Controller ctrl = new Controller();
            int status = ctrl.RegClub( txtClubName.Text, txtPresident.Text, txtVPresident.Text, txtSecretary.Text, txtRgstDate.Text, txtDescription.Text);

            if(status == 1)
            {
                MessageBox.Show("Club Registered Successfully!");
                dsh.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register", "Please try again!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewClub_Load(object sender, EventArgs e)
        {

        }
    }
}