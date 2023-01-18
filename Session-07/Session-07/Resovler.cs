using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    internal abstract class Resovler {

        public abstract void LogEventMessage(string description, DateTime timeStamp);
        public abstract void LogEventMessage(Guid requestID, string requestIn, string requestOut, ActionEnum action, DateTime timStamp);
        public abstract void LogEventError(Guid requestID, string requestIn, ActionEnum action, DateTime timStamp);
        public abstract void LogEventExceptionUppercase(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID);
        public abstract void LogEventExceptionReverse(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID);
        public abstract void LogEventExceptionConvert(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID);
        public virtual void LogNullEventError(Guid requestID, string requestIn, DateTime timeStamp) { }
    }
}
