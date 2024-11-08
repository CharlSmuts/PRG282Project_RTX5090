﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project
{
    internal class DataHandler
    {
        //Captures the information of a student, creates an instance of the Student class, and adds it to the list
        public List<Student> AddStudent(List<Student> studentlist, int ID, string name, string surname, int age, string course)
        {
            //The data must be captured in the Form.cs, and sent to the method, as the method does not have access to form components
            Student student = new Student(ID,name,surname,age,course);
            studentlist.Add(student);
           
            return studentlist;
        }



        //Finds the ID of the Student we want to edit the details from
        //Finds all the new information about the student, and apply the changes
        public void EditStudent(List<Student> studentlist, int IDtoEdit, int NewID, string NewName,string NewSurname, int NewAge, string NewCourse)
        {
            foreach (Student student in studentlist)
            {
                if (student.StudentID == IDtoEdit)
                {
                    student.StudentID = NewID;
                    student.Name = NewName;
                    student.Surname = NewSurname;
                    student.Age = NewAge;  
                    student.Course = NewCourse;
                    break;
                }
            }
        }

        public List<Student> DeleteStudent(List<Student> studentlist, int studentID)
        {
            string message = "You are about to delete student with the ID: " + studentID + ". Are you sure you want to continue?";

            /*  
                MessageBoxButtons is an Enum in the System.Windows.Forms namespace.
                It allows you to choose a defined mix of buttons you want on your message box
                This message box contains 2 buttons, "Yes" and "No"
                MessageBoxIcon works the same way
            */
            DialogResult userchoice = MessageBox.Show(message,"Warning!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            //int myint --- Dialogresult userchoice

            if (userchoice == DialogResult.Yes)
            {
                foreach (Student student in studentlist)
                {
                    if (student.StudentID == studentID)
                    {
                        studentlist.Remove(student);
                        break;
                    }
                }
            }

            return studentlist;
        }

        public List<Student> SearchStudent(List<Student> students)
        {
            int studentID;

            int.TryParse(Interaction.InputBox("Enter a Student ID", "Search for a student", ""), out studentID);
            List<Student> studentlist = new List<Student>();
            
            foreach(Student student in students)
            {
                if (student.StudentID == studentID)
                {
                    studentlist.Add(student);
                    break;
                }
            }
            if (studentlist.Count <= 0)
            {
                MessageBox.Show("That student doesnt exists");
                return students;
            }
            return studentlist;
        }

        public List<Student> SearchStudentName(List<Student> students)
        {
            string studentname;

            studentname = Interaction.InputBox("Enter a Student Name", "Search for a student", "").ToLower();
            List<Student> studentlist = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Name.ToLower() == studentname)
                {
                    studentlist.Add(student);
                    
                }
            }
            if (studentlist.Count <= 0)
            {
                MessageBox.Show("That student doesnt exists");
                return students;
            }
            return studentlist;
        }

        public List<Student> SortbyA(List<Student> students)
        {
            List<Student> sortedList = students.OrderBy(x => x.Name).ToList();
                
            return sortedList;
        }

        public List<Student> SortbyD(List<Student> students)
        {
            List<Student> sortedDecList = students.OrderByDescending(x => x.Name).ToList();

            return sortedDecList;
        }

    }
}
