using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Session_07 {
    internal class ActionResolver : Resovler {
        public MessageLogger Logger { get; set; }

        public ActionResolver() {
            Logger = new MessageLogger();
        }
        public ActionResponse Excecute(ActionRequest request) {
            var response = new ActionResponse();
            response.RequestID = request.RequestID;

            switch (request.Action) {
                case ActionEnum.Convert:
                    response.Output = DecimalToBinary(request.RequestID, request.Input);
                    if (response.Output != null) {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }

                    break;
                case ActionEnum.Uppercase:
                    response.Output = UppercaseTheBiggest(request.Input, request.RequestID);
                    if (response.Output != null) {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }
                    break;
                case ActionEnum.Reverse:
                    response.Output = ReverseString(request.Input, request.RequestID);
                    if (response.Output != null) {
                        LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
                    }
                    break;
                default:
                    response.Output = null;
                    LogEventError(request.RequestID, request.Input, request.Action, DateTime.Now);
                    break;

            }

            return response;
        }
        //convert to binary call / calculate and exception /
        public string DecimalToBinary(Guid requestID, string input) {
            string binaryOutput = null;
            int number;
            try {
                if (input == null) {
                    throw new ArgumentNullException("Parameter is null");
                }
                if (Int32.TryParse(input, out number)) {
                    binaryOutput = Convert.ToString((int)number, 2);
                }
                return binaryOutput;
            }
            catch (Exception ex) {
                LogEventExceptionConvert(input, ex, DateTime.Now, requestID);
                return null;
            }
        }
        
        public override void LogEventExceptionConvert(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID) {
            Logger.Write(new Message() {
                Content = $"## Request [{requestID}] : Exception in Action [Convert]: {exeption}. Input was'{requestIn}'.",
                TimeStamp = timeStamp
            });
        }

        // reverse string call / recursion handling and excepton
        public string ReverseString(string str, Guid requestID) {
            return ReverseStringRecursion(str, requestID);
        }

        public string ReverseStringRecursion(string str, Guid requestID) {
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

        //overide from resovler.cs
        public override void LogEventExceptionReverse(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID) {
            Logger.Write(new Message() {
                Content = $"## Request [{requestID}] : Exception in Action [Reverse]: {exeption}. Input was'{requestIn}'.",
                TimeStamp = timeStamp
            });

        }

        //uppercase segment 


        public string UppercaseTheBiggest(string str, Guid requestID) {
            int numOfWords = 0;
            int maxWordSize = 0;
            int? index = null;
            string outputUpper = str;
            if (!String.IsNullOrEmpty(str)) {

                try {
                    string[] words = str.Split(' ');
                    for (int i = 0; i < words.Length; i++) {
                        if (words[i] != String.Empty) {
                            CheckWordSize(ref numOfWords, ref maxWordSize, ref index, words, i);
                        }
                    }
                    if (index != null && numOfWords > 1) {
                        outputUpper = Rebuild(index, words);
                    }
                }
                catch (Exception ex) {
                    LogEventExceptionUppercase(str, ex, DateTime.Now, requestID);
                    return null;
                }
            }
            else { LogNullEventError(requestID, "NULL_TYPE", DateTime.Now);return null; }
            return outputUpper;
        }

        public void CheckWordSize(ref int numOfWords, ref int maxLength, ref int? index, string[] words, int i) {
            numOfWords++;
            if (words[i].Length > maxLength) {
                SwapBiggerWord(out maxLength, out index, words, i);
            }
        }

        public void SwapBiggerWord(out int maxLength, out int? index, string[] words, int i) {
            maxLength = words[i].Length;
            index = i;
        }

        public string Rebuild(int? index, string[] words) {
            string outputUpper;
            words[(int)index] = words[(int)index].ToUpper();
            outputUpper = string.Join(' ', words);
            return outputUpper;
        }

        //override abstract from resovler.cs
        public override void LogEventExceptionUppercase(string requestIn, Exception exeption, DateTime timeStamp, Guid requestID) {
            Logger.Write(new Message() {
                Content = $"## Request [{requestID}] : Exception in Action [UpperCase]: {exeption}. Input was: '{requestIn}'.",
                TimeStamp = timeStamp
            });
        }


        //override abstract from resovler.cs
        public override void LogEventMessage(string description, DateTime timeStamp) {
            Logger.Write(new Message() {
                Content = description,
                TimeStamp = timeStamp
            });
        }

        //override abstract from resovler.cs
        public override void LogEventMessage(Guid requestID, string requestIn, string requestOut, ActionEnum action, DateTime timeStamp) {
            Logger.Write(new Message() {
                Content = $"Request [{requestID}] : Opperation {action} on input: '{requestIn}'. Response output: '{requestOut}' .",
                TimeStamp = timeStamp
            });
        }
        public override void LogEventError(Guid requestID, string requestIn, ActionEnum action, DateTime timeStamp) {
            Logger.Write(new Message() {
                Content = $"## ERROR: Request [{requestID}] : Action was out of Scope: '{action}' with input: '{requestIn}'.",
                TimeStamp = timeStamp
            });
        }
        public override void LogNullEventError(Guid requestID, string requestIn, DateTime timeStamp) {
            Logger.Write(new Message() {
                Content = $"## ERROR: Request [{requestID}] : Null string handling.  with input: '{requestIn}'.",
                TimeStamp = timeStamp
            });
        }
    }
}
