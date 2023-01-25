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
        public int Year { get; set; }
        public int Month { get; set; }



        public LedgerFileHelper(int year , int month )
        {
            this.Year= year;
            this.Month= month;

        }


        public void  AppendToLedger(decimal income , decimal expenses , decimal total )
        {
            try
            {
                string fileName = ($"{this.Year}-{this.Month}.dat");
                using (var fileStream = new FileStream(fileName, FileMode.Append))
                {
                    var bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(fileStream, objectToSerialize);
                }
            } catch (Exception e) 
            { 
            
                    ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);
                    exceptionLogger.Log(e.ToString());


                    
            }

        }




    }


   


}
