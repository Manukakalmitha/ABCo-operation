using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Co_operation
{
    public partial class UI : Form
    {
        public static UI intense;
        public Label lablegreet;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");

        public UI()
        {
            InitializeComponent();
            intense = this;
            lablegreet= greeting;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee obj = new Update_Employee();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee obj = new Update_Employee();
            obj.Show();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome obj = new Welcome();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee ob = new employee();
            ob.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void homeToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            employee obj = new employee();
            obj.Show();
        }
    }
}
