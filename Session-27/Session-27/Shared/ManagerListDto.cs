using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared {
    public class ManagerListDto {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
        public int SalaryPerMonth { get; set; }
    //    public List<Engineer> Engineers { get; set; } = new List<Engineer>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();


    }
}
