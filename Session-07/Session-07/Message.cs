using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    internal class Message {
        public Guid ID { get; }
        public DateTime TimeStamp { get; set; }
        public string Content { get; set; } //changed name of Message:String

        public Message() {
            ID = Guid.NewGuid();
        }
    }
}
