namespace Project
{
    partial class SummaryReport
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
            this.btnExitSummary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOldest = new System.Windows.Forms.Label();
            this.lblYoungest = new System.Windows.Forms.Label();
            this.lblAveAge = new System.Windows.Forms.Label();
            this.lblFirstStudent = new System.Windows.Forms.Label();
            this.lblLastStudent = new System.Windows.Forms.Label();
            this.lblCommonName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMCDegree = new System.Windows.Forms.Label();
            this.lblLCDegree = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitSummary
            // 
            this.btnExitSummary.Location = new System.Drawing.Point(707, 9);
            this.btnExitSummary.Name = "btnExitSummary";
            this.btnExitSummary.Size = new System.Drawing.Size(93, 33);
            this.btnExitSummary.TabIndex = 1;
            this.btnExitSummary.Text = "Exit";
            this.btnExitSummary.UseVisualStyleBackColor = true;
            this.btnExitSummary.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 298);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lblCommonName);
            this.groupBox1.Controls.Add(this.lblLastStudent);
            this.groupBox1.Controls.Add(this.lblFirstStudent);
            this.groupBox1.Controls.Add(this.lblAveAge);
            this.groupBox1.Controls.Add(this.lblYoungest);
            this.groupBox1.Controls.Add(this.lblOldest);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Summary";
            // 
            // lblOldest
            // 
            this.lblOldest.AutoSize = true;
            this.lblOldest.Location = new System.Drawing.Point(6, 30);
            this.lblOldest.Name = "lblOldest";
            this.lblOldest.Size = new System.Drawing.Size(278, 16);
            this.lblOldest.TabIndex = 0;
            this.lblOldest.Text = "Oldest student :  Piet Pompues 23 Course: BIT";
            // 
            // lblYoungest
            // 
            this.lblYoungest.AutoSize = true;
            this.lblYoungest.Location = new System.Drawing.Point(6, 56);
            this.lblYoungest.Name = "lblYoungest";
            this.lblYoungest.Size = new System.Drawing.Size(300, 16);
            this.lblYoungest.TabIndex = 1;
            this.lblYoungest.Text = "Youngest student: Koos Roos 18 Course: BCOMP";
            // 
            // lblAveAge
            // 
            this.lblAveAge.AutoSize = true;
            this.lblAveAge.Location = new System.Drawing.Point(6, 83);
            this.lblAveAge.Name = "lblAveAge";
            this.lblAveAge.Size = new System.Drawing.Size(106, 16);
            this.lblAveAge.TabIndex = 2;
            this.lblAveAge.Text = "Average age: 17";
            // 
            // lblFirstStudent
            // 
            this.lblFirstStudent.AutoSize = true;
            this.lblFirstStudent.Location = new System.Drawing.Point(6, 108);
            this.lblFirstStudent.Name = "lblFirstStudent";
            this.lblFirstStudent.Size = new System.Drawing.Size(304, 16);
            this.lblFirstStudent.TabIndex = 3;
            this.lblFirstStudent.Text = "First student added: Piet Pompues 23 Course: BIT.";
            // 
            // lblLastStudent
            // 
            this.lblLastStudent.AutoSize = true;
            this.lblLastStudent.Location = new System.Drawing.Point(6, 133);
            this.lblLastStudent.Name = "lblLastStudent";
            this.lblLastStudent.Size = new System.Drawing.Size(311, 16);
            this.lblLastStudent.TabIndex = 4;
            this.lblLastStudent.Text = "Last student added: Koos Roos 18 Course: BCOMP";
            // 
            // lblCommonName
            // 
            this.lblCommonName.AutoSize = true;
            this.lblCommonName.Location = new System.Drawing.Point(6, 159);
            this.lblCommonName.Name = "lblCommonName";
            this.lblCommonName.Size = new System.Drawing.Size(421, 16);
            this.lblCommonName.TabIndex = 5;
            this.lblCommonName.Text = "The most common name is Piet with a total of 3 students with that name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.lblLCDegree);
            this.groupBox2.Controls.Add(this.lblMCDegree);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Summary";
            // 
            // lblMCDegree
            // 
            this.lblMCDegree.AutoSize = true;
            this.lblMCDegree.Location = new System.Drawing.Point(6, 28);
            this.lblMCDegree.Name = "lblMCDegree";
            this.lblMCDegree.Size = new System.Drawing.Size(500, 16);
            this.lblMCDegree.TabIndex = 0;
            this.lblMCDegree.Text = "The most common degree is bcomp with a total of 8 students enrolled in that degre" +
    "e";
            // 
            // lblLCDegree
            // 
            this.lblLCDegree.AutoSize = true;
            this.lblLCDegree.Location = new System.Drawing.Point(6, 55);
            this.lblLCDegree.Name = "lblLCDegree";
            this.lblLCDegree.Size = new System.Drawing.Size(479, 16);
            this.lblLCDegree.TabIndex = 1;
            this.lblLCDegree.Text = "The least common degree is BIT with a total of 3 students enrolled in that degree" +
    "";
            // 
            // SummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitSummary);
            this.Name = "SummaryReport";
            this.Text = "SummaryReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryReport_FormClosed);
            this.Load += new System.EventHandler(this.SummaryReport_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExitSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOldest;
        private System.Windows.Forms.Label lblYoungest;
        private System.Windows.Forms.Label lblAveAge;
        private System.Windows.Forms.Label lblFirstStudent;
        private System.Windows.Forms.Label lblLastStudent;
        private System.Windows.Forms.Label lblCommonName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMCDegree;
        private System.Windows.Forms.Label lblLCDegree;
    }
}