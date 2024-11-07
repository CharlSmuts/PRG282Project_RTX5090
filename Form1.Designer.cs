namespace Project
{
    partial class frmStudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRecords));
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutStudents = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblOutAAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllStudents = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudents = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAscSort = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnNextRecord = new System.Windows.Forms.Button();
            this.btnPrevRecord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(774, 87);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(568, 401);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_RowEnter);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Black;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAddStudent.FlatAppearance.BorderSize = 2;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 3);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(283, 95);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Black;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReport.FlatAppearance.BorderSize = 2;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(3, 407);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(283, 95);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Generate a summary report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(152, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total number of student: ";
            // 
            // lblOutStudents
            // 
            this.lblOutStudents.AutoSize = true;
            this.lblOutStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStudents.Location = new System.Drawing.Point(168, 18);
            this.lblOutStudents.Name = "lblOutStudents";
            this.lblOutStudents.Size = new System.Drawing.Size(177, 39);
            this.lblOutStudents.TabIndex = 7;
            this.lblOutStudents.Text = "OStudents";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(6, 88);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(162, 16);
            this.lblAverageAge.TabIndex = 8;
            this.lblAverageAge.Text = "Average Age of Students: ";
            // 
            // lblOutAAge
            // 
            this.lblOutAAge.AutoSize = true;
            this.lblOutAAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutAAge.Location = new System.Drawing.Point(168, 78);
            this.lblOutAAge.Name = "lblOutAAge";
            this.lblOutAAge.Size = new System.Drawing.Size(231, 39);
            this.lblOutAAge.TabIndex = 9;
            this.lblOutAAge.Text = "OAverageAge";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Marco";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(87, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(151, 22);
            this.txtAge.TabIndex = 3;
            this.txtAge.Text = "20";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(87, 160);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(151, 22);
            this.txtCourse.TabIndex = 4;
            this.txtCourse.Text = "BCOMP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course:";
            // 
            // btnAllStudents
            // 
            this.btnAllStudents.BackColor = System.Drawing.Color.Black;
            this.btnAllStudents.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAllStudents.FlatAppearance.BorderSize = 2;
            this.btnAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudents.ForeColor = System.Drawing.Color.White;
            this.btnAllStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnAllStudents.Image")));
            this.btnAllStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllStudents.Location = new System.Drawing.Point(3, 205);
            this.btnAllStudents.Name = "btnAllStudents";
            this.btnAllStudents.Size = new System.Drawing.Size(283, 95);
            this.btnAllStudents.TabIndex = 7;
            this.btnAllStudents.Text = "View all students";
            this.btnAllStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllStudents.UseVisualStyleBackColor = false;
            this.btnAllStudents.Click += new System.EventHandler(this.btnAllStudents_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 24;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(87, 82);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(151, 22);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "Jacobs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Controls.Add(this.btnAddStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnAllStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 512);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 2;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.Image")));
            this.btnDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(3, 104);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(283, 95);
            this.btnDeleteStudent.TabIndex = 6;
            this.btnDeleteStudent.Text = "Delete a Student";
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudents
            // 
            this.btnUpdateStudents.BackColor = System.Drawing.Color.Black;
            this.btnUpdateStudents.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnUpdateStudents.FlatAppearance.BorderSize = 2;
            this.btnUpdateStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudents.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudents.Image")));
            this.btnUpdateStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateStudents.Location = new System.Drawing.Point(3, 306);
            this.btnUpdateStudents.Name = "btnUpdateStudents";
            this.btnUpdateStudents.Size = new System.Drawing.Size(283, 95);
            this.btnUpdateStudents.TabIndex = 8;
            this.btnUpdateStudents.Text = "Update Student Information";
            this.btnUpdateStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStudents.UseVisualStyleBackColor = false;
            this.btnUpdateStudents.Click += new System.EventHandler(this.btnUpdateSInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCourse);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 209);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.BtnAscSort);
            this.panel1.Controls.Add(this.btnSearchName);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(303, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 512);
            this.panel1.TabIndex = 29;
            // 
            // BtnAscSort
            // 
            this.BtnAscSort.BackColor = System.Drawing.Color.Black;
            this.BtnAscSort.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnAscSort.FlatAppearance.BorderSize = 2;
            this.BtnAscSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAscSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAscSort.ForeColor = System.Drawing.Color.White;
            this.BtnAscSort.Image = ((System.Drawing.Image)(resources.GetObject("BtnAscSort.Image")));
            this.BtnAscSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAscSort.Location = new System.Drawing.Point(216, 446);
            this.BtnAscSort.Name = "BtnAscSort";
            this.BtnAscSort.Size = new System.Drawing.Size(169, 56);
            this.BtnAscSort.TabIndex = 33;
            this.BtnAscSort.Text = "Sort Ascending";
            this.BtnAscSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAscSort.UseVisualStyleBackColor = false;
            this.BtnAscSort.Click += new System.EventHandler(this.BtnAscSort_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.Black;
            this.btnSearchName.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSearchName.FlatAppearance.BorderSize = 2;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchName.Image")));
            this.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchName.Location = new System.Drawing.Point(216, 367);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(169, 56);
            this.btnSearchName.TabIndex = 32;
            this.btnSearchName.Text = "Search by Name";
            this.btnSearchName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Black;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSort.FlatAppearance.BorderSize = 2;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSort.Location = new System.Drawing.Point(3, 446);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(169, 56);
            this.btnSort.TabIndex = 31;
            this.btnSort.Text = "Sort Decending";
            this.btnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(3, 367);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 56);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search by ID";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblOutStudents);
            this.groupBox2.Controls.Add(this.lblAverageAge);
            this.groupBox2.Controls.Add(this.lblOutAAge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 143);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Information";
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.BackColor = System.Drawing.Color.Black;
            this.btnLastRecord.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnLastRecord.FlatAppearance.BorderSize = 2;
            this.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastRecord.Location = new System.Drawing.Point(489, 10);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(75, 31);
            this.btnLastRecord.TabIndex = 14;
            this.btnLastRecord.Text = ">|";
            this.btnLastRecord.UseVisualStyleBackColor = false;
            this.btnLastRecord.Click += new System.EventHandler(this.btnLastRecord_Click);
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.BackColor = System.Drawing.Color.Black;
            this.btnFirstRecord.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnFirstRecord.FlatAppearance.BorderSize = 2;
            this.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstRecord.Location = new System.Drawing.Point(3, 10);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(75, 31);
            this.btnFirstRecord.TabIndex = 11;
            this.btnFirstRecord.Text = "|<";
            this.btnFirstRecord.UseVisualStyleBackColor = false;
            this.btnFirstRecord.Click += new System.EventHandler(this.btnFirstRecord_Click);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.BackColor = System.Drawing.Color.Black;
            this.btnNextRecord.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNextRecord.FlatAppearance.BorderSize = 2;
            this.btnNextRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRecord.Location = new System.Drawing.Point(344, 10);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(75, 31);
            this.btnNextRecord.TabIndex = 13;
            this.btnNextRecord.Text = ">";
            this.btnNextRecord.UseVisualStyleBackColor = false;
            this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
            // 
            // btnPrevRecord
            // 
            this.btnPrevRecord.BackColor = System.Drawing.Color.Black;
            this.btnPrevRecord.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnPrevRecord.FlatAppearance.BorderSize = 2;
            this.btnPrevRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevRecord.Location = new System.Drawing.Point(180, 10);
            this.btnPrevRecord.Name = "btnPrevRecord";
            this.btnPrevRecord.Size = new System.Drawing.Size(75, 31);
            this.btnPrevRecord.TabIndex = 12;
            this.btnPrevRecord.Text = "<";
            this.btnPrevRecord.UseVisualStyleBackColor = false;
            this.btnPrevRecord.Click += new System.EventHandler(this.btnPrevRecord_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnPrevRecord);
            this.panel2.Controls.Add(this.btnNextRecord);
            this.panel2.Controls.Add(this.btnFirstRecord);
            this.panel2.Controls.Add(this.btnLastRecord);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(774, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 105);
            this.panel2.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(424, 49);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 56);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // frmStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 607);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentRecords";
            this.Text = "Student Records";
            this.Load += new System.EventHandler(this.frmStudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutStudents;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblOutAAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllStudents;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnNextRecord;
        private System.Windows.Forms.Button btnPrevRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button BtnAscSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

