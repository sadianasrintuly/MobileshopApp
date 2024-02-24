using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tuly
{
    public partial class stockmarcket : Form
    {
        public stockmarcket()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;

            cmd.CommandText = "Select * from  newphonerecord where model='"+ textBoxsearch.Text + "'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            if(DS.Tables[0].Rows.Count != 0)
            {
                
                label2.Text = DS.Tables[0].Rows[0][1].ToString();
                MName.Text = DS.Tables[0].Rows[0][2].ToString();
                Ram.Text = DS.Tables[0].Rows[0][3].ToString();
                Istorage.Text = DS.Tables[0].Rows[0][4].ToString();
                EStoeage.Text = DS.Tables[0].Rows[0][5].ToString();
                Display.Text = DS.Tables[0].Rows[0][6].ToString();
                Fcamera.Text = DS.Tables[0].Rows[0][7].ToString();
                BCamera.Text = DS.Tables[0].Rows[0][8].ToString();
                SimType.Text = DS.Tables[0].Rows[0][9].ToString();
                price.Text = DS.Tables[0].Rows[0][10].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addnewphone_Click(object sender, EventArgs e)
        {
            MainForm mainForm=new MainForm();
            mainForm.ShowDialog();
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
            delete del =new delete();
            del.Show();
            this.Hide();
        }

        private void stockmarcket_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mobileGallary mobileGallary = new mobileGallary();
            mobileGallary.Show();
            this.Hide();
        }
    }
}
