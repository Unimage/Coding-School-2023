using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Grade
    {
        public Guid ID { get; }
        public Guid StudentID { get; }
        public Guid CourseID { get; }
        public int Mark { get; set; }

        public Grade()
        {

        }
        public Grade(Guid id)
        {
            ID = id;
        }
        public Grade(Guid id , Guid courseId , Guid studentId)
        {
            ID = id;
            CourseID = courseId;
            StudentID = studentId;
        }
        public Grade(Guid id, Guid courseId, Guid studentId, int mark)
        {
            ID = id;
            CourseID = courseId;
            StudentID = studentId;
            Mark = mark;
        }
        //TODO: Refactor the uneeded constructors on later verion

    }
}
