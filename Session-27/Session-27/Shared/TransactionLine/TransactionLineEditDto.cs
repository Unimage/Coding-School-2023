using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class TransactionLineEditDto {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }
        public int TransactionId { get; set; }
        public int ServiceTaskId { get; set; }
        public int EngineerId { get; set; }


    }
}
