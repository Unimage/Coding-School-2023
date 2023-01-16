using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class University : Institute
    {
        Student[] Students;
        Course[] Courses;
        Grade[] Grades;
        Schedule[] ScheduledCourses;

        public University()
        {
            Students = new Student[100];
            Courses = new Course[20];
            Grades = new Grade[200]; //courses * students
            ScheduledCourses = new Schedule[60];
        }  
        public University(Guid id, string name, int yearsInService):base(id,name, yearsInService)
        {
            Students = new Student[100];
            Courses = new Course[20];
            Grades = new Grade[200]; //courses * students
            ScheduledCourses = new Schedule[60];
        }

        //added another one for importing a whole university with all data
        public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduledCourses) : base(id, name, yearsInService)
        {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourses = scheduledCourses;
        }
        public void GetStudents()
        {

        }
        public void GetCourses()
        {

        }
        public void GetGrades() 
        {

        }
        public void SetSchedule(Guid coursID, Guid professorID, DateTime datetime)
        {

        }
    }
}
