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
    public partial class WeeklyReport : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
        string id;
        int id1;
        int delete_id;

        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            fill_grid();
        }

        public void fill_grid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Clubs.ClubId, Clubs.ClubName, WeeklyReport.ReportDate, WeeklyReport.Activities, WeeklyReport.Achievements from Clubs,WeeklyReport";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells["ClubId"].Value.ToString();

            if (id == "")
            {
                id1 = 0;
            }
            else
            {
                id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClubId"].Value.ToString());

            }

            if (id1 == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Clubs,WeeklyReport values('" + dataGridView1.Rows[e.RowIndex].Cells["ClubID"].Value.ToString() + "','" + dataGridView1.Rows[e.RowIndex].Cells["ReportDate"].Value.ToString() + "', '" + dataGridView1.Rows[e.RowIndex].Cells["Activities"].Value.ToString() + "', '" + dataGridView1.Rows[e.RowIndex].Cells["Achievements"].Value.ToString() + "')";
                cmd.ExecuteNonQuery();
                fill_grid();

            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update WeeklyReport set ClubName='" + dataGridView1.Rows[e.RowIndex].Cells["ClubName"].Value.ToString() + "', ReportDate='" + dataGridView1.Rows[e.RowIndex].Cells["ReportDate"].Value.ToString() + "', Activities='" + dataGridView1.Rows[e.RowIndex].Cells["Activities"].Value.ToString() + "', Achievements='" + dataGridView1.Rows[e.RowIndex].Cells["Achievements"].Value.ToString() + "' where id=" + id1 + "";
                cmd.ExecuteNonQuery();
                fill_grid();
            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClubId"].Value.ToString());
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Clubs,WeeklyReport where ClubId=" + delete_id + "";
            cmd.ExecuteNonQuery();
            fill_grid();

        }

        private void cLUBREPRESENTATIVESECRETARYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblWReport_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEDESCRIPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubDescription ua = new ClubDescription();
            ua.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeeklyReport login = new WeeklyReport();
            login.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
