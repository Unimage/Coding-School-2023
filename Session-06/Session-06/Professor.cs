using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses;


        public Professor()
        {
            Courses = new Course[20];
        }
        
        public Professor(Guid id, string name) :base(id,name) 
        {

        }
        public Professor(Guid id, string name,string rank, Course[] courses) : base(id, name)
        {
            Rank = rank;
            Courses= courses;


        }
        //TODO: IMPLEMENT METHODS
        public void Teach(Course course,DateTime datetime)
        {
           
        }
        public void SetGrade(Guid studentID,Guid courseID,int grade) 
        {

        }
        public void GetName()
        {
            //TODO: change type to string and return 
        }

    }
}
