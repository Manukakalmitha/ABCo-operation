namespace ABC_Co_operation
{
    partial class employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Reg = new System.Windows.Forms.Button();
            this.EmpNum = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empmanagementDataSet = new ABC_Co_operation.empmanagementDataSet();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Emptype = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.TextBox();
            this.DPname = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.homeno = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.mobileno = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.addrebox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.femalebox = new System.Windows.Forms.CheckBox();
            this.malebox = new System.Windows.Forms.CheckBox();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesTableAdapter = new ABC_Co_operation.empmanagementDataSetTableAdapters.EmployeesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empmanagementDataSet1 = new ABC_Co_operation.empmanagementDataSet1();
            this.employeesTableAdapter1 = new ABC_Co_operation.empmanagementDataSet1TableAdapters.EmployeesTableAdapter();
            this.updateEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empmanagementDataSet)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empmanagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(174, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(353, 32);
            this.label14.TabIndex = 19;
            this.label14.Text = "Register New Employees";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Reg);
            this.panel5.Controls.Add(this.EmpNum);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label17);
            this.panel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(12, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1295, 472);
            this.panel5.TabIndex = 17;
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.Location = new System.Drawing.Point(1101, 390);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(108, 54);
            this.Reg.TabIndex = 1;
            this.Reg.Text = "Register";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // EmpNum
            // 
            this.EmpNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmNo", true));
            this.EmpNum.Location = new System.Drawing.Point(197, 35);
            this.EmpNum.MaxLength = 10;
            this.EmpNum.Name = "EmpNum";
            this.EmpNum.Size = new System.Drawing.Size(186, 22);
            this.EmpNum.TabIndex = 0;
            this.EmpNum.TextChanged += new System.EventHandler(this.EmpNum_TextChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.empmanagementDataSet;
            // 
            // empmanagementDataSet
            // 
            this.empmanagementDataSet.DataSetName = "empmanagementDataSet";
            this.empmanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(611, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Basic Details";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(83, 288);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(140, 16);
            this.label24.TabIndex = 5;
            this.label24.Text = "Department Details";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Emptype);
            this.panel8.Controls.Add(this.Designation);
            this.panel8.Controls.Add(this.DPname);
            this.panel8.Controls.Add(this.label30);
            this.panel8.Controls.Add(this.label31);
            this.panel8.Controls.Add(this.label32);
            this.panel8.Location = new System.Drawing.Point(68, 298);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(490, 146);
            this.panel8.TabIndex = 6;
            // 
            // Emptype
            // 
            this.Emptype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmpType", true));
            this.Emptype.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Emptype.Location = new System.Drawing.Point(171, 103);
            this.Emptype.Name = "Emptype";
            this.Emptype.Size = new System.Drawing.Size(186, 22);
            this.Emptype.TabIndex = 2;
            // 
            // Designation
            // 
            this.Designation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Designation", true));
            this.Designation.Location = new System.Drawing.Point(171, 68);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(298, 22);
            this.Designation.TabIndex = 1;
            // 
            // DPname
            // 
            this.DPname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "DepName", true));
            this.DPname.Location = new System.Drawing.Point(171, 29);
            this.DPname.Name = "DPname";
            this.DPname.Size = new System.Drawing.Size(298, 22);
            this.DPname.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(44, 103);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 16);
            this.label30.TabIndex = 2;
            this.label30.Text = "Employee Type";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(44, 68);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 16);
            this.label31.TabIndex = 1;
            this.label31.Text = "Designation";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(44, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(117, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Department Name";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.homeno);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.mobileno);
            this.panel7.Controls.Add(this.emailbox);
            this.panel7.Controls.Add(this.addrebox);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Location = new System.Drawing.Point(589, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(620, 185);
            this.panel7.TabIndex = 4;
            // 
            // homeno
            // 
            this.homeno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HomeNo", true));
            this.homeno.Location = new System.Drawing.Point(171, 149);
            this.homeno.Name = "homeno";
            this.homeno.Size = new System.Drawing.Size(186, 22);
            this.homeno.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 149);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 16);
            this.label28.TabIndex = 9;
            this.label28.Text = "Home Number";
            // 
            // mobileno
            // 
            this.mobileno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "MobileNo", true));
            this.mobileno.Location = new System.Drawing.Point(171, 103);
            this.mobileno.Name = "mobileno";
            this.mobileno.Size = new System.Drawing.Size(186, 22);
            this.mobileno.TabIndex = 2;
            // 
            // emailbox
            // 
            this.emailbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Email", true));
            this.emailbox.Location = new System.Drawing.Point(171, 68);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(298, 22);
            this.emailbox.TabIndex = 1;
            // 
            // addrebox
            // 
            this.addrebox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ADRESS", true));
            this.addrebox.Location = new System.Drawing.Point(171, 29);
            this.addrebox.Name = "addrebox";
            this.addrebox.Size = new System.Drawing.Size(298, 22);
            this.addrebox.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(44, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 16);
            this.label25.TabIndex = 2;
            this.label25.Text = "Mobile Number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(44, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 16);
            this.label26.TabIndex = 1;
            this.label26.Text = "Email";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(44, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "Address";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.femalebox);
            this.panel6.Controls.Add(this.malebox);
            this.panel6.Controls.Add(this.lastnamebox);
            this.panel6.Controls.Add(this.firstnamebox);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Location = new System.Drawing.Point(68, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 184);
            this.panel6.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 107);
            this.dateTimePicker1.MaxDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 24);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // femalebox
            // 
            this.femalebox.AutoSize = true;
            this.femalebox.Location = new System.Drawing.Point(319, 148);
            this.femalebox.Name = "femalebox";
            this.femalebox.Size = new System.Drawing.Size(75, 20);
            this.femalebox.TabIndex = 4;
            this.femalebox.Text = "Female";
            this.femalebox.UseVisualStyleBackColor = true;
            // 
            // malebox
            // 
            this.malebox.AutoSize = true;
            this.malebox.Location = new System.Drawing.Point(171, 148);
            this.malebox.Name = "malebox";
            this.malebox.Size = new System.Drawing.Size(59, 20);
            this.malebox.TabIndex = 3;
            this.malebox.Text = "Male";
            this.malebox.UseVisualStyleBackColor = true;
            // 
            // lastnamebox
            // 
            this.lastnamebox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LName", true));
            this.lastnamebox.Location = new System.Drawing.Point(171, 68);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(298, 22);
            this.lastnamebox.TabIndex = 1;
            // 
            // firstnamebox
            // 
            this.firstnamebox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FName", true));
            this.firstnamebox.Location = new System.Drawing.Point(171, 29);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(298, 22);
            this.firstnamebox.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(44, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 16);
            this.label22.TabIndex = 3;
            this.label22.Text = "Gender";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(44, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Date of Birth";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Contact Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Last Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(44, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "First Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(71, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Employee Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Co_operation.Properties.Resources.ABC_Co_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.updateEmployeesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.updateEmployeeToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(211, 26);
            this.homeToolStripMenuItem1.Text = "Home";
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emNoDataGridViewTextBoxColumn1,
            this.fNameDataGridViewTextBoxColumn1,
            this.lNameDataGridViewTextBoxColumn1,
            this.genderDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.mobileNoDataGridViewTextBoxColumn1,
            this.homeNoDataGridViewTextBoxColumn1,
            this.depNameDataGridViewTextBoxColumn1,
            this.designationDataGridViewTextBoxColumn1,
            this.empTypeDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.employeesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 646);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1295, 254);
            this.dataGridView1.TabIndex = 22;
            // 
            // emNoDataGridViewTextBoxColumn1
            // 
            this.emNoDataGridViewTextBoxColumn1.DataPropertyName = "EmNo";
            this.emNoDataGridViewTextBoxColumn1.HeaderText = "EmNo";
            this.emNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emNoDataGridViewTextBoxColumn1.Name = "emNoDataGridViewTextBoxColumn1";
            this.emNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            this.fNameDataGridViewTextBoxColumn1.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn1.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            this.fNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn1
            // 
            this.lNameDataGridViewTextBoxColumn1.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn1.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn1.Name = "lNameDataGridViewTextBoxColumn1";
            this.lNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "birth";
            this.birthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESSDataGridViewTextBoxColumn1
            // 
            this.aDRESSDataGridViewTextBoxColumn1.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn1.HeaderText = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aDRESSDataGridViewTextBoxColumn1.Name = "aDRESSDataGridViewTextBoxColumn1";
            this.aDRESSDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mobileNoDataGridViewTextBoxColumn1
            // 
            this.mobileNoDataGridViewTextBoxColumn1.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn1.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn1.Name = "mobileNoDataGridViewTextBoxColumn1";
            this.mobileNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // homeNoDataGridViewTextBoxColumn1
            // 
            this.homeNoDataGridViewTextBoxColumn1.DataPropertyName = "HomeNo";
            this.homeNoDataGridViewTextBoxColumn1.HeaderText = "HomeNo";
            this.homeNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.homeNoDataGridViewTextBoxColumn1.Name = "homeNoDataGridViewTextBoxColumn1";
            this.homeNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // depNameDataGridViewTextBoxColumn1
            // 
            this.depNameDataGridViewTextBoxColumn1.DataPropertyName = "DepName";
            this.depNameDataGridViewTextBoxColumn1.HeaderText = "DepName";
            this.depNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.depNameDataGridViewTextBoxColumn1.Name = "depNameDataGridViewTextBoxColumn1";
            this.depNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // designationDataGridViewTextBoxColumn1
            // 
            this.designationDataGridViewTextBoxColumn1.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn1.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn1.Name = "designationDataGridViewTextBoxColumn1";
            this.designationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // empTypeDataGridViewTextBoxColumn1
            // 
            this.empTypeDataGridViewTextBoxColumn1.DataPropertyName = "EmpType";
            this.empTypeDataGridViewTextBoxColumn1.HeaderText = "EmpType";
            this.empTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.empTypeDataGridViewTextBoxColumn1.Name = "empTypeDataGridViewTextBoxColumn1";
            this.empTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.empmanagementDataSet1;
            // 
            // empmanagementDataSet1
            // 
            this.empmanagementDataSet1.DataSetName = "empmanagementDataSet1";
            this.empmanagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // updateEmployeesToolStripMenuItem
            // 
            this.updateEmployeesToolStripMenuItem.Name = "updateEmployeesToolStripMenuItem";
            this.updateEmployeesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.updateEmployeesToolStripMenuItem.Text = "Update Employees";
            this.updateEmployeesToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeesToolStripMenuItem_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1319, 912);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empmanagementDataSet)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empmanagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox EmpNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox Emptype;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.TextBox DPname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox homeno;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox mobileno;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox addrebox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox femalebox;
        private System.Windows.Forms.CheckBox malebox;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private empmanagementDataSet empmanagementDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private empmanagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private empmanagementDataSet1 empmanagementDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private empmanagementDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeesToolStripMenuItem;
    }
}