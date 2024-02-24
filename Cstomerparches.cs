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

namespace tuly
{
    public partial class Cstomerparches : Form
    {
        public Cstomerparches()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = Tname.Text;
            String Gender = comboBoxGender.Text;
            String contactno = textBoxcontactno.Text;
            String emailid = textemailid.Text;
            String address = textadress.Text;
            String Company= comboBoxcompany.Text;
            String model= comboBoxmodel.Text;
       
            String storage = comboBoxinternalStorage.Text;
            String price= textBoxprice.Text;

            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;
            cmd.CommandText = "insert into Customer_perches (name,Gender,contactno,emailid,address,Company,model,storage,price) values('" + name + "','" + Gender + "'," + contactno + ",'" + emailid + "','" + address + "','" + Company + "','" + model + "','" + storage + "','" + price + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            Co.Close();
            MessageBox.Show("Data Saved", "New Employee", MessageBoxButtons.OK);


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

        private void addnewphone_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mobileGallary mobileGallary = new mobileGallary();
            mobileGallary.Show();
            this.Hide();
        }

        private void textboxname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
