using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Co_operation
{
    public partial class Update_Employee : Form
    {
        int ID;
        DataTable dt;
        public static Update_Employee intense;
        public TextBox tb;


        SqlDataAdapter adapter;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Update_Employee()
        {
            InitializeComponent();
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {


            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee ob = new employee();
            ob.Show();

        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI ob = new UI();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();


            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void registerToolStripMenuItem_clicked(object sender, EventArgs e)
        {
            this.Hide();
            employee obj = new employee();
            obj.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string Gender;
            if (malebox.Checked)
            {
                Gender= "Male";

            }
            else
            {
                Gender= "Female";

            }
            SqlCommand cmd = new SqlCommand("update Employees set FName = '"+firstnamebox.Text+"',LName = '"+lastnamebox.Text+"',Gender ='"+Gender+"',ADRESS='"+addrebox.Text+"',Email='"+emailbox.Text+"',MobileNo='"+mobileno.Text+"',HomeNo='"+homeno.Text+"',DepName='"+DPname.Text+"',Designation='"+designation.Text+"',EmpType='"+Emptype.Text+"' where EmNo='"+empnumber.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee Data has been updated");
            clear();
            Binddata();

        }
        public void clear()
        {
            empnumber.Text="";
            firstnamebox.Text="";
            lastnamebox.Text="";
            addrebox.Text="";
            emailbox.Text="";
            mobileno.Text="";
            homeno.Text="";
            DPname.Text="";
            designation.Text="";
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
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adapter =new SqlDataAdapter("select * from Employees ", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (empnumber.Text !="")
            {
                SqlCommand cmd = new SqlCommand("select * from Employees where EmNo='"+int.Parse(empnumber.Text)+"'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource=dataTable;

                SqlCommand cmd2 = new SqlCommand("select FName,LName,ADRESS,Email,MobileNo,HomeNo,DepName,Designation,EmpType from Employees where EmNo='"+int.Parse(empnumber.Text)+"'", con);
                con.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    firstnamebox.Text=reader.GetValue(0).ToString();
                    lastnamebox.Text=reader.GetValue(1).ToString();
                    addrebox.Text=reader.GetValue(2).ToString();
                    emailbox.Text=reader.GetValue(3).ToString();
                    mobileno.Text=reader.GetValue(4).ToString();
                    homeno.Text=reader.GetValue(5).ToString();
                    DPname.Text=reader.GetValue(6).ToString();
                    designation.Text=reader.GetValue(7).ToString();
                    Emptype.Text=reader.GetValue(8).ToString();
                }
                con.Close();

            }
            else
            {
                Binddata();
                clear();
            }

        }









        private void empnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)13)
            {
                button1.PerformClick();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee ob = new employee();
            ob.Show();
        }

        private void empnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            MessageBox.Show("Are you really want to delete the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2CCLKED2\MSSQLSERVER1;Initial Catalog=empmanagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete Employees where EmNo='"+int.Parse(empnumber.Text)+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record successfully Deleted!");
            Binddata();





        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            UI ob = new UI();
            ob.Show();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob = new Login();
            ob.Show();

        }

        private void registerEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee ob = new employee();
            ob.Show();
        }
    }






}

