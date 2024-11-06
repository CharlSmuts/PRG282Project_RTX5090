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
            this.btnUpdateSInfo = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateDGV = new System.Windows.Forms.Button();
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
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnNextRecord = new System.Windows.Forms.Button();
            this.btnPrevRecord = new System.Windows.Forms.Button();
            this.btnAllStudents = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(1114, 247);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(568, 401);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_RowEnter);
            // 
            // btnUpdateSInfo
            // 
            this.btnUpdateSInfo.BackColor = System.Drawing.Color.Black;
            this.btnUpdateSInfo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnUpdateSInfo.FlatAppearance.BorderSize = 2;
            this.btnUpdateSInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSInfo.Image")));
            this.btnUpdateSInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSInfo.Location = new System.Drawing.Point(3, 508);
            this.btnUpdateSInfo.Name = "btnUpdateSInfo";
            this.btnUpdateSInfo.Size = new System.Drawing.Size(283, 95);
            this.btnUpdateSInfo.TabIndex = 8;
            this.btnUpdateSInfo.Text = "Update Student Information";
            this.btnUpdateSInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateSInfo.UseVisualStyleBackColor = false;
            this.btnUpdateSInfo.Click += new System.EventHandler(this.btnUpdateSInfo_Click);
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
            this.btnDeleteStudent.Location = new System.Drawing.Point(3, 407);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(283, 95);
            this.btnDeleteStudent.TabIndex = 6;
            this.btnDeleteStudent.Text = "Delete a Student";
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
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
            // btnUpdateDGV
            // 
            this.btnUpdateDGV.Location = new System.Drawing.Point(832, 100);
            this.btnUpdateDGV.Name = "btnUpdateDGV";
            this.btnUpdateDGV.Size = new System.Drawing.Size(170, 40);
            this.btnUpdateDGV.TabIndex = 10;
            this.btnUpdateDGV.Text = "Update DGV";
            this.btnUpdateDGV.UseVisualStyleBackColor = true;
            this.btnUpdateDGV.Click += new System.EventHandler(this.btnUpdateDGV_Click);
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
            this.btnReport.Location = new System.Drawing.Point(3, 609);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(283, 95);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Generate a summary report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(446, 586);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total number of student";
            // 
            // lblOutStudents
            // 
            this.lblOutStudents.AutoSize = true;
            this.lblOutStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStudents.Location = new System.Drawing.Point(571, 574);
            this.lblOutStudents.Name = "lblOutStudents";
            this.lblOutStudents.Size = new System.Drawing.Size(177, 39);
            this.lblOutStudents.TabIndex = 7;
            this.lblOutStudents.Text = "OStudents";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(446, 646);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(126, 13);
            this.lblAverageAge.TabIndex = 8;
            this.lblAverageAge.Text = "Average Age of Students";
            // 
            // lblOutAAge
            // 
            this.lblOutAAge.AutoSize = true;
            this.lblOutAAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutAAge.Location = new System.Drawing.Point(578, 625);
            this.lblOutAAge.Name = "lblOutAAge";
            this.lblOutAAge.Size = new System.Drawing.Size(231, 39);
            this.lblOutAAge.TabIndex = 9;
            this.lblOutAAge.Text = "OAverageAge";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(518, 274);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Marco";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(518, 352);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(151, 20);
            this.txtAge.TabIndex = 3;
            this.txtAge.Text = "20";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(518, 391);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(151, 20);
            this.txtCourse.TabIndex = 4;
            this.txtCourse.Text = "BCOMP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course:";
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Location = new System.Drawing.Point(1114, 664);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(75, 23);
            this.btnFirstRecord.TabIndex = 11;
            this.btnFirstRecord.Text = "|<";
            this.btnFirstRecord.UseVisualStyleBackColor = true;
            this.btnFirstRecord.Click += new System.EventHandler(this.btnFirstRecord_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Location = new System.Drawing.Point(1484, 664);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(75, 23);
            this.btnLastRecord.TabIndex = 14;
            this.btnLastRecord.Text = ">|";
            this.btnLastRecord.UseVisualStyleBackColor = true;
            this.btnLastRecord.Click += new System.EventHandler(this.btnLastRecord_Click);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.Location = new System.Drawing.Point(1353, 664);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(75, 23);
            this.btnNextRecord.TabIndex = 13;
            this.btnNextRecord.Text = ">";
            this.btnNextRecord.UseVisualStyleBackColor = true;
            this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
            // 
            // btnPrevRecord
            // 
            this.btnPrevRecord.Location = new System.Drawing.Point(1241, 664);
            this.btnPrevRecord.Name = "btnPrevRecord";
            this.btnPrevRecord.Size = new System.Drawing.Size(75, 23);
            this.btnPrevRecord.TabIndex = 12;
            this.btnPrevRecord.Text = "<";
            this.btnPrevRecord.UseVisualStyleBackColor = true;
            this.btnPrevRecord.Click += new System.EventHandler(this.btnPrevRecord_Click);
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
            this.lblSurname.Location = new System.Drawing.Point(515, 297);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 24;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(518, 313);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(151, 20);
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Controls.Add(this.btnAddStudent);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnAllStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateSInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 512);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 95);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete a Student";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnDeleteStudent_Click);
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
            // frmStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1717, 739);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateDGV);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnPrevRecord);
            this.Controls.Add(this.btnNextRecord);
            this.Controls.Add(this.btnLastRecord);
            this.Controls.Add(this.btnFirstRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOutAAge);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblOutStudents);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentRecords";
            this.Text = "Student Records";
            this.Load += new System.EventHandler(this.frmStudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnUpdateSInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateDGV;
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
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnNextRecord;
        private System.Windows.Forms.Button btnPrevRecord;
        private System.Windows.Forms.Button btnAllStudents;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateStudents;
    }
}

