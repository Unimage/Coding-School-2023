using Session_27.Model;
using Session_27.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class TransactionEditDto
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public List<CustomerEditDto> Customers { get; set; } = new();
        public int ManagerId { get; set; }
        public List<ManagerEditDto> Managers { get; set; } = new();
        public int CarId { get; set; }
        public List<CarEditDto> Cars { get; set; } = new();
        public List<TransactionLineEditDto> TransactionLines { get; set; } = new();
    }
}
