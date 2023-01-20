using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Schedule {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule(Guid courseID, Guid professorID,DateTime time) {
            CourseID = courseID;
            ProfessorID = professorID;
            ID = Guid.NewGuid();
            Calendar = time;
        }
        public Schedule() { }
    }
}
