using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SummaryReport : Form
    {
        public SummaryReport()
        {
            InitializeComponent();
        }

        //An example of how the summary list's data can look like
        /*
            Oldest student: StudentID: 1 | Name: Piet | Surname: Pompues Age: 23 | Course: BIT
            Youngest student: StudentID: 2 | Name: Koos | Surname: Roos Age: 18 | Course: BCOMP
            Avarage age: 17
            First student added: StudentID: 1 | Name: Piet | Surname: Pompues Age: 23 | Course: BIT
            Last student added: StudentID: 2 | Name: Koos | Surname: Roos Age: 18 | Course: BCOMP
            The most common name is Piet with a total of 3 students with that name
            The most common degree is bcomp with a total of 8 students enrolled in that degree
            The least common degree is BIT with a total of 3 students enrolled in that degree
        */

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentRecords f1 = new frmStudentRecords();
            f1.ShowDialog();
        }

        private void SummaryReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmStudentRecords f1 = new frmStudentRecords();
            f1.ShowDialog();
        }

        private void SummaryReport_Load(object sender, EventArgs e)
        {
            List<string> summarylist = new List<string>();
            ListTransfer transfer = new ListTransfer();
            summarylist = transfer.getList();
        }
    }
}
