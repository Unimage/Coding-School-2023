using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Session_07{
    internal class ActionResolver : Resovler {
        public MessageLogger Logger { get; set; }

        public ActionResolver() {
            Logger = new MessageLogger();
        }


        




//convert to binary call / calculate and exception /
        public string  DecimalToBinary(Guid requestID, string input) {
            string binaryOutput = null;
            int number;
            try {
                if(input== null) {
                    throw new ArgumentNullException("Parameter is null");
                }
                if(Int32.TryParse(input,out number)) {
                    binaryOutput = Calculate(number);     
                }
                return binaryOutput;
            }
            catch (Exception ex) {
                LogEventExceptionConvert(input, ex, DateTime.Now, requestID);
                return null;
            }


        }
        public string Calculate(int number) {
            string result = string.Empty;
            while (number > 1) {
                int remainder = number % 2;
                result = Convert.ToString(remainder) + result;
                number /= 2;
            }
            result=Convert.ToString(number);
            return result;
        }
        
        public void LogEventExceptionConvert(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID) {
            Logger.Write(new Message() {
                Content = $"## Request [{requestID}] : Exception in Action [Convert]: {exeption}. Input was'{requestIn}'.",
                TimeStamp = timeStamp
            });
        }

// reverse string call / recursion handling and excepton
        string ReverseString(string str, Guid requestID) {
            return ReverseStringRecursion(str, requestID);
        }

        private string ReverseStringRecursion(string str, Guid requestID) {
            try {
                if (str.Length > 0)
                    return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1), requestID);
                else
                    return str;
            }
            catch (Exception ex) {
                LogEventExceptionReverse(str, ex, DateTime.Now, requestID);
                return null;
            }
        }

        private void LogEventExceptionReverse(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID) {
            Logger.Write(new Message() {
                Content = $"## Request [{requestID}] : Exception in Action [Reverse]: {exeption}. Input was'{requestIn}'.",
                TimeStamp = timeStamp
            });

        }

    }
}
