using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// in order to access the db context we need to
// include the Models folder in our script
using COMP1004_F2016_Lesson8.Models;

namespace COMP1004_F2016_Lesson8
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void GetStudents()
        {
            // connect to the db using ef
            CollegeContext db = new CollegeContext();

            // use LINQ to access the student table in the db
            
            /* 
            var StudentList = (from student in db.Students
                               select student).ToList();
            SAME THING AS BELOW
            */

            List<Student> StudentList = (from student in db.Students
                                         select student).ToList();

            // display the StudentList in the DataGridView
            StudentDataGridView.DataSource = StudentList;
        }
    }
}
