using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Course
    {
        public Guid ID { get; }
        public string Code { get; set; }
        public string Subject { get; set; }


        public Course()
        {
            
        }
        public Course(Guid id)
        {
            ID = id;
        }
        public Course(Guid id , string subject)
        {
            ID = id;
            Subject = subject;
        }
        public Course(Guid id , string code , string subject)
        {
            ID = id;
            Code = code;
            Subject = subject;    
        }
        //TODO: refactor constructors so GUID is auto-generated.
    }
}
