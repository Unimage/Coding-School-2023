using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    internal class LedgerFileHelper


        
    {
         MonthlyLedger monthlyLedger { get; set; }



        public LedgerFileHelper(MonthlyLedger monthlyLedger )
        {
            

        }


        public void  AppendToLedger( )
        {
            try
            {
                string fileName = ($"{monthlyLedger.Year}-{monthlyLedger.Month}.json");
                using (var fileStream = new FileStream(fileName, FileMode.Append))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, monthlyLedger);
                }
            } catch (Exception e) 
            { 
            
                    ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);
                    exceptionLogger.Log(e.ToString());


                    
            }

        }




    }


   


}
