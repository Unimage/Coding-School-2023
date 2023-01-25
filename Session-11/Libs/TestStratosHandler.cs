using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs {
    public class TestStratosHandler {
        TestStratos LedgerOfTheMonth { get; set; } = new TestStratos();

        public void CheckAndInitializeLedger(DateTime date, List<Employee> Employees) {
            string fileName = $"MonthLyledger{date.Year}_{date.Month}.json";
            if (File.Exists(fileName)) {
                DeserializeLedger(fileName); // works  loads already existin ledger 
            }
            else {
                LedgerOfTheMonth = new TestStratos(Employees); //create a new one from strach using cronstructor provided.
            }
        }
        public void DeserializeLedger(string filename) {
            Serializer serializer = new Serializer();
            LedgerOfTheMonth = serializer.DeserializeFromFile<TestStratos>(filename);
        }
        public void SerializeLedger() {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(LedgerOfTheMonth, "Ledger.json");
        }

        public void AddNewTransactionToLedger(Transaction trans) {
            foreach (var tmp in trans.TransactionLines) {
                LedgerOfTheMonth.Expenses += tmp.Quantity * tmp.Product.Cost;
            }
            LedgerOfTheMonth.Income += trans.TotalPrice;
            LedgerOfTheMonth.UpdateTotal();
        }
    }
}
