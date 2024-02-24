using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tuly
{
    public partial class customerRecord : Form
    {
        public customerRecord()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerRecord_Load(object sender, EventArgs e)
        {
            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;

            cmd.CommandText = "Select * from Customer_perches";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;

            cmd.CommandText = "Select * from Customer_perches where name ='" + textBox1.Text+"'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void addnewphone_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sellsmen sellsmen = new Sellsmen();
            sellsmen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cstomerparches cstomerparches = new Cstomerparches();
            cstomerparches.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockmarcket stockmarcket = new stockmarcket();
            stockmarcket.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerRecord customerRecord = new customerRecord();
            customerRecord.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delete delete = new delete();
            delete.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mobileGallary mobileGallary = new mobileGallary();
            mobileGallary.Show();
            this.Hide();
        }
    }
}
