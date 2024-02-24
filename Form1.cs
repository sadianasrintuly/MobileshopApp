namespace tuly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uid = UID.Text;
            String password = PASSWORD.Text;
            if(uid=="sadia" && password == "1111001")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}