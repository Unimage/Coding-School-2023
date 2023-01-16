using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] Courses;


        public Student() 
        {
            Courses = new Course[20];

        }
        public Student(Guid id , string name,int registrationNumber ):base(id,name)
        {
            RegistrationNumber = registrationNumber;
        }
        public Student(Guid id, string name, int registrationNumber, Course[] courses) : base(id, name)
        {
            RegistrationNumber = registrationNumber;
            Courses = new Course[20];
        }


        //TODO: Implement methods Attend and WriteExam
        public void Attend(Course course,DateTime datetime)
        {
            
        }
        public void WriteExam(Course course, DateTime datetime)
        {

        }
    }
}
