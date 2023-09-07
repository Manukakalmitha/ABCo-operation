using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Co_operation
{
    public partial class Welcome : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
        SqlCommand cmd;
        public Welcome()
        {
            InitializeComponent();
        }


        private void Welcome_Load(object sender, PaintEventArgs e)
        {




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd= new SqlCommand("insert into librararian values('" +fullname.Text+ "','" +emailtxt.Text+ "','" +pass.Text+ "')", con);
            cmd.ExecuteNonQuery();
            var result = MessageBox.Show("Registration Successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();
            }
            con.Close();






        }
        public static void main(string[] args)
        {
            Application.Run(new Login());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            con.Open();
            cmd= new SqlCommand("insert into librararian values('" +fullname.Text+ "','" +emailtxt.Text+ "','" +pass.Text+ "')", con);
            cmd.ExecuteNonQuery();
            var result = MessageBox.Show("Registration Successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();
            }
            con.Close();
        }
    }


}








