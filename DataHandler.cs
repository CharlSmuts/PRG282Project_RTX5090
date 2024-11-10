using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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


        public List<string> summaryReport(List<Student> studentsLists)
        {
            int youngest = 500;
            int oldest = -500;
            string oldestStudent = "", youngestStudent = "";  

            int totalAge = 0;         //calculates total age

            foreach(Student student in studentsLists)  //goes through list to find oldest and youngest student
            {
                if(student.Age > oldest)
                {
                    oldest = student.Age;
                    oldestStudent = "Oldest Student: " + student.ToString();
                }

                if(student.Age < youngest)
                {
                    youngest = student.Age;
                    youngestStudent = "Youngest Student: " + student.ToString();
                }

                totalAge += student.Age;
            }

            double avarageAge = (double)totalAge / studentsLists.Count;

            string firstStudentAdded = "First student added: "+studentsLists[1].ToString();
            string lastStudent = "Last student added: "+studentsLists[studentsLists.Count - 1].ToString();      //First and most recently student added


            Dictionary<string, int> nameCount = new Dictionary<string, int>();   //Most common name
            foreach(Student student in studentsLists)
            {
                string temp = student.Name;//I have no clue why this works, but please leave it alone.
                if (nameCount.ContainsKey(temp))
                {
                    nameCount[temp]++;
                }
                else
                {
                    nameCount[temp] = 1;
                }
            }

            string mostCommonName = "";
            int higestCount = 0;
            foreach (var Name in nameCount)
            {
                if (Name.Value > higestCount)
                {
                    higestCount = Name.Value;
                    mostCommonName = Name.Key;
                }
            }
            //////
            Dictionary<string, int> degreeCount = new Dictionary<string, int>();  //most and least common degrees
            foreach(Student student in studentsLists)
            {
                if(degreeCount.ContainsKey(student.Course))
                    degreeCount[student.Course]++;

                else
                {
                    degreeCount[student.Course] = 1;
                }
            }

            string mostCommonDegree = "";
            string leastCommonDegree = "";
            int maxDegreeCount = -500;
            int minDegreeCount = 500;

            foreach (var degree in degreeCount)
            {
                if (degree.Value > maxDegreeCount)
                {
                    mostCommonDegree = degree.Key;
                    maxDegreeCount = degree.Value;
                }
                if (degree.Value < minDegreeCount)

                    minDegreeCount = degree.Value;
                    leastCommonDegree = degree.Key;
            }

            List<string> returnvalues = new List<string>();
            returnvalues.Add(oldestStudent);//Oldest student: + ToString()
            returnvalues.Add(youngestStudent);//Youngest student: + ToString()
            returnvalues.Add("Avarage age: "+Math.Round(avarageAge,2));
            returnvalues.Add(firstStudentAdded);//First student added: + ToString();
            returnvalues.Add(lastStudent);//Last student added: + ToString();
            returnvalues.Add("The most common name is "+mostCommonName+" with a total of "+higestCount+" students with that name");
            returnvalues.Add("The most common degree is " + mostCommonDegree + " with a total of " + maxDegreeCount + " students enrolled in that degree");
            returnvalues.Add("The least common degree is " + leastCommonDegree + " with a total of " + minDegreeCount + " students enrolled in that degree");
            return returnvalues;
        }
    }
}
