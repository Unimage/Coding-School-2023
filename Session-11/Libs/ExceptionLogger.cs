using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    // append error messages received through try-catch and log them with append to a file "exceptions.txt"
    internal class ExceptionLogger
    {
        public string  ErrorMessage { get; set; }

        public ExceptionLogger() { }


        public void Log(string message) {


            string logfile = @"exceptions.txt";

            //the file does NOT exist 
            if(!File.Exists(logfile)) 
            {
                using (StreamWriter streamWriter = new StreamWriter(logfile))
                {
                    streamWriter.WriteLine("Error Logger for Coffee Shop");
                }

            }
            else
            {
                using (StreamWriter streamWriter = File.AppendText(logfile){

                    
                    streamWriter.WriteLine(System.DateTime.Today);
                    streamWriter.WriteLine(message);
                    streamWriter.Close();

                }
                {
                    
                }
            }



        
        }
    }
}
