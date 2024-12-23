﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmStudentRecords : Form
    {
        BindingSource bindingSource = new BindingSource();
        DataHandler dataHandler = new DataHandler();
        FileHandler fileHandler = new FileHandler();
        static List<Student> studentlist = new List<Student>();
        static int IDholder = 1;
        bool sortAsc = true;

        public frmStudentRecords()
        {
            InitializeComponent();
        }

        private void frmStudentRecords_Load(object sender, EventArgs e)//Executes right after the form has been loaded
        {
            //Here we will read the data in the tf using the FileHandler, and add it to our list
            studentlist.Clear();
            studentlist = fileHandler.PopulateList(studentlist);
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //To add a student, we supply an ID, to ensure there are no duplicate ID's. To do this, we found the ID that was last assigned, and +1
            int id = 0;
            foreach (var student in studentlist)
            {
                id = student.StudentID;//Thus, we will loop through the entire list, and assign the value of the ID of the last student in the list
            }

            studentlist = dataHandler.AddStudent(studentlist, (id + 1), txtName.Text, txtSurname.Text, int.Parse(txtAge.Text), txtCourse.Text);
            fileHandler.AddStudent(studentlist);
            MessageBox.Show("The student has been successfully added!", "Student Captured");
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
            FillTexts();
        }

        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
            IDholder--;
        }

        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
            IDholder++;
        }

        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
            IDholder = 1;
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
            IDholder = studentlist.Count;
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
            FillTexts();
        }

        private void btnUpdateSInfo_Click(object sender, EventArgs e)
        {
            
            
            this.dgvStudents.CurrentCell = this.dgvStudents[0, dgvStudents.CurrentCell.RowIndex];
            string test = $"{dgvStudents.CurrentCell.Value}";
            IDholder = int.Parse(test);

            dataHandler.EditStudent(studentlist, IDholder, IDholder, txtName.Text, txtSurname.Text,  int.Parse(txtAge.Text), txtCourse.Text);
            fileHandler.UpdateStudent(studentlist);
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
                
            FillTexts();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            this.dgvStudents.CurrentCell = this.dgvStudents[0, dgvStudents.CurrentCell.RowIndex];
            string test = $"{dgvStudents.CurrentCell.Value}";
            IDholder = int.Parse(test);

            studentlist = dataHandler.DeleteStudent(studentlist, IDholder);
            fileHandler.DeleteStudent(studentlist);
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            IDholder = 1;
            updateStudentCounter();
            findAverageAge();
            FillTexts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = dataHandler.SearchStudent(studentlist);
            dgvStudents.DataSource = bindingSource;
            FillTexts();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = dataHandler.SortbyD(studentlist);
            dgvStudents.DataSource = bindingSource;
            FillTexts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//Force closes all instances of the process
        }

        private void BtnAscSort_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = dataHandler.SortbyA(studentlist);
            dgvStudents.DataSource = bindingSource;
            FillTexts();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = dataHandler.SearchStudentName(studentlist);
            dgvStudents.DataSource = bindingSource;
            FillTexts();
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            List<string> summary = new List<string>();
            summary = dataHandler.summaryReport(studentlist);
            ListTransfer transfer = new ListTransfer(summary);

            //Close the current form and open the form to display the report
            this.Hide();
            SummaryReport f2 = new SummaryReport();
            f2.ShowDialog();
        }

        //////////////////////////Tracking functions
        private void updateStudentCounter()
        {
            lblOutStudents.Text = studentlist.Count.ToString();
        }

        private void findAverageAge()
        {
            float total = 0;
            foreach (Student student in studentlist)
            {
                total += student.Age;
            }
            float avarage = (total / studentlist.Count);
            lblOutAAge.Text = String.Format("{0}",Math.Round(avarage, 2));
        }

        private void btnUpdateDGV_Click(object sender, EventArgs e)
        {
            //Update met wat u mean, refresh??
            dgvStudents.Refresh();
            dgvStudents.Update();
            MessageBox.Show("Data is sucessfully updated!");
        }

        private void FillTexts()
        {
            if (dgvStudents.SelectedCells.Count > 0)
            {
                int row = dgvStudents.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvStudents.Rows[row];
                txtName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtSurname.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txtAge.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtCourse.Text = Convert.ToString(selectedRow.Cells[4].Value);
            }
        }

        private void dgvStudents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillTexts();
        }

        private void frmStudentRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);//Mega murder spree
        }
    }
}