using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class SelectDate : Form
    {
        public SelectDate()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            ClubActivitiesReport car = new ClubActivitiesReport();
            car.Show();
            this.Close();
        }
    }
}
