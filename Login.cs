using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Secretary;
using WindowsFormsApp2;

namespace Login
{
    public partial class LI : Form
    {
        public LI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPw.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controller ctrl = new Controller();
            string role = ctrl.SignIn(txtUsername.Text, txtPw.Text);
            if (role == "Admin")
            {
                Dashboard dsh = new Dashboard();
                dsh.Show();
                this.Hide();
            }
            else if (role == "Secretary")
            {
                WeeklyReport wr = new WeeklyReport();
                wr.Show();
                this.Hide();
            }
            else if (role == "Student")
            {
                Search sr = new Search();
                sr.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}