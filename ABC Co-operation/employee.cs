using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Co_operation
{
    public partial class employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
        SqlCommand cmd;

        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {




        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();


            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI ob = new UI();
            ob.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
            if (EmpNum.Text==""||firstnamebox.Text==""||lastnamebox.Text=="" ||addrebox.Text==""||emailbox.Text==""||mobileno.Text==""||homeno.Text==""||DPname.Text==""||Designation.Text==""||Emptype.Text=="")
            {
                MessageBox.Show("Please complete the Form");
            }


            else
            {
                try
                {

                    string Gender;
                    if (malebox.Checked)
                    {
                        Gender= "Male";

                    }
                    else
                    {
                        Gender= "Female";

                    }



                    cmd = new SqlCommand("insert into Employees (EmNo,FName,LName,Gender,birth,ADRESS,Email,MobileNo,HomeNo,DepName,Designation,EmpType) values('"+EmpNum.Text+"','"+firstnamebox.Text+"','"+lastnamebox.Text+"','"+Gender+"','"+DateTime.Parse(dateTimePicker1.Text)+"','"+addrebox.Text+"','"+emailbox.Text+"','"+mobileno.Text+"','"+homeno.Text+"','"+DPname.Text+"','"+Designation.Text+"','"+Emptype.Text+"'  )", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successfully completed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    clear();
                    Binddata();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void clear()
        {
            EmpNum.Text="";
            firstnamebox.Text="";
            lastnamebox.Text="";
            addrebox.Text="";
            emailbox.Text="";
            mobileno.Text="";
            homeno.Text="";
            DPname.Text="";
            Designation.Text="";
            Emptype.Text="";
        }
        void Binddata()
        {
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EmpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI obj = new UI();
            obj.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee obj = new Update_Employee();
            obj.Show();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void updateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee obj = new Update_Employee(); obj.Show();
        }
    }
}
