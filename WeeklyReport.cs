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
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = |DataDirectory|\\TestDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public WeeklyReport()
        {
            InitializeComponent();
            DisplayData();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLUBREPRESENTATIVESECRETARYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert Data 
            if (txtName.Text != "" && txtAct.Text != "" && txtAch.Text != "")
            {
                cmd = new SqlCommand("insert into WeeklyReport(Name,Activity,Achievement) values(@name,@activity,@achievement)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@activity", txtAct.Text);
                cmd.Parameters.AddWithValue("@achievement", txtAch.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }
        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Clubs,WeeklyReport", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txtName.Text = "";
            lblAct.Text = "";
            txtAch.Text = "";
            ID = 0;
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAct.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAch.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
        //Update Record  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAct.Text != "" && txtAch.Text != "")
            {
                cmd = new SqlCommand("update WeeklyReport set Name=@name,Activity=@activity,Achievement=@Achievement where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@activity", lblAct.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete Record  
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete WeeklyReport where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
