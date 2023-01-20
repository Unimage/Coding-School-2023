using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uni;

namespace Session_10 {
    public partial class Form1 : Form {
        public University university;
        public Handler handler;

        public Form1() {
            university = new University();
            handler = new Handler();

            //to be changed location
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }
        private void LoadDefault() {
            handler.PopulateData();
            bsCourses.DataSource = handler.University.Courses;
            bsStudents.DataSource = handler.University.Students;
            bsScheduledCourses.DataSource = handler.University.ScheduledCourses;
            bsGrades.DataSource = handler.University.Grades;

            dvgStudents.DataSource = bsStudents;
            dvgGrades.DataSource = bsGrades;
            dvgCourses.DataSource = bsCourses;
            dvgScheduledCourses.DataSource = bsScheduledCourses;
            //temporary fix for saving in case its loaded.
            university = handler.University;
        }
        public void SavetoFile() {
            handler.SerializeToFile(university,"university.json");
        }
        public void LoadFile() {
            
            university= handler.Deserialize("university.json");
            
            bsStudents.DataSource = university.Students;
            bsCourses.DataSource = university.Courses;
            bsScheduledCourses.DataSource = university.ScheduledCourses;
            bsGrades.DataSource = university.Grades;
            

            dvgStudents.DataSource = bsStudents;
            dvgGrades.DataSource = bsGrades;
            dvgCourses.DataSource = bsCourses;
            dvgScheduledCourses.DataSource = bsScheduledCourses;

        }

        private void btnDefault_Click(object sender, EventArgs e) {
            LoadDefault();
        }

        private void btnLoadFile_Click(object sender, EventArgs e) {
            LoadFile();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e) {
            SavetoFile();
        }
    }


   
}
