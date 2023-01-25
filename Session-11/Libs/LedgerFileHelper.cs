using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Libs
{
    public  class LedgerFileHelper
        {
        MonthlyLedger monthlyLedger { get; set; } = new MonthlyLedger();



        public LedgerFileHelper(MonthlyLedger monthlyLedgerInput )
        {
            monthlyLedger = monthlyLedgerInput;
        }
        public LedgerFileHelper() {
        }

        public void  AppendToLedger(MonthlyLedger monthlyLedger)
        {

            try
            {

                string fileName = ($"{monthlyLedger.Year}-{monthlyLedger.Month}.json");

                string jsonString = JsonSerializer.Serialize(monthlyLedger);

                File.WriteAllText(fileName, jsonString);

             

             

            } catch (Exception e) 
            { 
                    ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);
                    exceptionLogger.Log(e.ToString());   
            }
        }

        public List<MonthlyLedger> DeserializeLedger(string fileName) {

            var LedgerList = new List<MonthlyLedger>();
            try {
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    var bFormatter = new BinaryFormatter();
                    while (fileStream.Position != fileStream.Length)
                    {
                        LedgerList.Add((MonthlyLedger)bFormatter.Deserialize(fileStream));
                    }
                }
            } catch (Exception e) {

                ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);
                exceptionLogger.Log(e.ToString());
            }
            return LedgerList;
        }
    }
}
