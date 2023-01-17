using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    internal class Resovler {
        public virtual void LogEventMessage(string description, DateTime timeStamp) { }
        public virtual void LogEventMessage(Guid requestID, string requestIn, string requestOut, ActionEnum action, DateTime timStamp) { }
        public virtual void LogEventError(Guid requestID, string requestIn, ActionEnum action, DateTime timStamp) { }
    }
}
