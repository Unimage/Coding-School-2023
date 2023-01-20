using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Student : Person {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public Student(string name, int age, int registrationNumber,List<Course>courseList ) : base(name, age) {
            RegistrationNumber = registrationNumber;
            Courses = courseList;
        }
    }
    
}
