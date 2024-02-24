using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuly
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cstomerparches cstomerparches = new Cstomerparches();
            cstomerparches.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textboxcompany.Clear();
            textboxmodel_name.Clear();
            textBoxprice.Clear();
            comboBoxram.SelectedIndex = -1;
            comboBoxinternalStorage.SelectedIndex = -1;
            comboBoxExStorage.SelectedIndex = -1;
            comboBoxDisplay.SelectedIndex = -1;
            comboBoxFontcamera.SelectedIndex = -1;
            comboBoxBackCamer.SelectedIndex = -1;
            comboBoxSim.SelectedIndex = -1;
            textBoxprice.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           String company= textboxcompany.Text;
           String model= textboxmodel_name.Text;
           Int64 price =Int64.Parse( textBoxprice.Text);
           String Ram= comboBoxram.Text;
           String internalstorage = comboBoxinternalStorage.Text;
           String Externalstorage=  comboBoxExStorage.Text;
           String Display = comboBoxDisplay.Text;
           String fontcamera = comboBoxFontcamera.Text;
           String backcamera= comboBoxBackCamer.Text;
           String sim = comboBoxSim.Text;

            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = HP\\SQLEXPRESS; database =mobileshop ;integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;

            cmd.CommandText = "insert into newphonerecord (company,model,price,Ram,internalstorage,Externalstorage,Display,fontcamera,backcamera,sim) values('"+ company+ "','"+ model+ "',"+ price + ",'"+ Ram + "','"+ internalstorage + "','"+ Externalstorage + "','"+ Display + "','"+ fontcamera + "','"+ backcamera + "','"+ sim + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS =new DataSet();

            DA.Fill(DS);
            Co.Close();
            MessageBox.Show("Data Saved","New phone Addes", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sellsmen sellsmen = new Sellsmen();
            sellsmen.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockmarcket stockmarcket= new stockmarcket();
            stockmarcket.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerRecord customerRecord = new customerRecord();
            customerRecord.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void addnewphone_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delete delete = new delete();
            delete.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mobileGallary mobileGallary = new mobileGallary();
            mobileGallary.Show();
            this.Hide();
        }
    }
}
