using System;
using System.Linq;

namespace CoffeeShop.Model {
    [Serializable]

    public class Employee:BaseEntity {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public decimal Salary { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Transaction Transaction { get; set; }


        public Employee() {
            ID = Guid.NewGuid();
        }

    }

}
