using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Schedule
    {
        public Guid ID { get; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule()
        {
        }

        public Schedule(Guid id)
        {
            ID = id;
        }

        public Schedule(Guid id, Guid courseID, Guid professorID)
        {
            CourseID = courseID;
            ProfessorID = professorID;
            ID= id;
        }

        //TODO: Add missing constructors / remove uneeded.
    }
}
