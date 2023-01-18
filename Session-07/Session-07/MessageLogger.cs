using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    internal class MessageLogger {
        public Message[] Messages { get; }
        int storedMessages = 0;
        int maxStoredMessages = 100;

        public MessageLogger() {
            Messages = new Message[maxStoredMessages];
        }

        public string ReadAll() {
            string msgLog = String.Empty;
            for (int i = 0; i < storedMessages; i++) {
                msgLog += Messages[i].Content + "\n";
            }
            return msgLog;
        }

        public void Clear() {
            Array.Clear(Messages, 0, Messages.Length);
            storedMessages= 0;
        }

        public void Write(Message msg) {
            if (storedMessages <= maxStoredMessages) {
                Messages[storedMessages] = msg;
                storedMessages++;
            }
        }
    }
}
