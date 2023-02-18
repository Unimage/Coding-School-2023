using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Employee {
        //Atributes 
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; } 
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //Attributes for Authentication
        public string username { get; set; }
        public string password { get; set; }

        public Employee() {
            ID= Guid.NewGuid();
        }

        //Employee Relations : Transaction 1-N
        public List<Transaction> TransactionList { get; set; }=new List<Transaction>();

       
    }
}
