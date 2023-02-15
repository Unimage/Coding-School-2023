using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class EngineerEditDto {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
        // Relations
        public int ManagerId { get; set; }
        public List<ManagerListDto> Managers { get; set; } = new();

        public List<Session_27.Model.TransactionLine> TransactionLines { get; set; } =new List<Session_27.Model.TransactionLine>();
    }
}

