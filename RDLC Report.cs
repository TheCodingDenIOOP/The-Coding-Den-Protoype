using System;
using System.Windows.Forms;

namespace Login
{
    public partial class RDLC_Report : Form
    {
        public RDLC_Report()
        {
            InitializeComponent();
        }

        private void RDLC_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsClubActivity.WeeklyReport' table. You can move, or remove it, as needed.
            this.WeeklyReportTableAdapter.Fill(this.dsClubActivity.WeeklyReport);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
