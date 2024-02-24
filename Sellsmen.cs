using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuly
{
    public partial class Sellsmen : Form
    {
        public Sellsmen()
        {
            InitializeComponent();
        }

        private void Sellsmen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textboxname.Text;
            String Gender = comboBoxGender.Text;
            String contactno = textBoxcontactno.Text;
            String emailid = textemailid.Text;
            String salary = textsalary.Text;
            String address = richTextBoxaddress.Text;
            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;
            cmd.CommandText = "insert into Sellsemen (name,Gender,contactno,emailid,salary,address) values('" + name + "','" + Gender + "'," + contactno + ",'" + emailid + "','" + salary + "','" + address + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            Co.Close();
            MessageBox.Show("Data Saved", "New Employee", MessageBoxButtons.OK);
        }

        private void addnewphone_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cstomerparches cstomerparches = new Cstomerparches();
            cstomerparches.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sellsmen sellsmen = new Sellsmen();
            sellsmen.Show();
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
