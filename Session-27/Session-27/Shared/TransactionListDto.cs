using Microsoft.Identity.Client;
using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class TransactionListDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int ManagerId { get; set; }
        public int CarId { get; set; }
        public CarEditDto Car { get; set; } = null!;
        public CustomerEditDto Customer { get; set; } = null!;
        public ManagerEditDto Manager { get; set; } = null!;


    }
}
