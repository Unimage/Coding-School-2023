using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Grade {
        public Grade() {

        }
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Mark { get; set; }
        public Grade( Guid courseId, Guid studentId, int mark) {
            ID = Guid.NewGuid();
            CourseID = courseId;
            StudentID = studentId;
            Mark = mark;
        }


    }
}
