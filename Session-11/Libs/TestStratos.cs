using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs {
    public class TestStratos {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public TestStratos() {
        }

        public TestStratos(List<Employee> empList) {
            foreach (var emp in empList) {
                Income = 0m;
                Total = 0m;
                Expenses += emp.Salary; //load to expenses all salaries
            }
            Expenses += 3000m; //rent  is loaded as expense too
        }

        public void UpdateTotal() {
            Total = Total + Income - Expenses;
        }
    }
}
