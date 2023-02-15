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

        // Relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ServiceTaskId { get; set; }
        public List<ServiceTaskEditDto> ServiceTasks { get; set; } = new();

        public int EngineerId { get; set; }
        public List<EngineerEditDto> Engineers { get; set; } = new();

    }
}
