using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Co_operation
{
    public partial class Login : Form
    {
        public static Login intense;
        public TextBox tb;
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
            intense = this;
            tb= emailtxt;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnclear_Click(object sender, EventArgs e)
        {
            emailtxt.Clear();
            pass.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {







        }







        private void Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (emailtxt.Text  == "")
            {
                MessageBox.Show("Email cannot be a blank");



            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Password cannot be a blank", "Invalid Login Details", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);


            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select *  from librararian where email = @email and pass = @pass", con);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                    cmd.Parameters.AddWithValue("@pass", pass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        UI ob = new UI();
                        ob.Show();

                        UI.intense.lablegreet.Text=emailtxt.Text;
                    }



                    else
                    {
                        MessageBox.Show("Invalid Email or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }


                con.Close();
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Welcome obj = new Welcome();
            obj.Show();
        }
    }
}
