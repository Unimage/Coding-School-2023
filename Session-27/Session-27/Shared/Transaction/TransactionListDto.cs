using Session_27.Model;
using Session_27.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class TransactionListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; } 
        public int CarId { get; set; }
        public Car Car  { get; set; } 

        //Relations
        public List<Session_27.Model.TransactionLine> TransactionLines { get; set; } = new();
    }
}
