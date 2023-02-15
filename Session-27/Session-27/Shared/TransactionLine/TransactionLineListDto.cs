using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class TransactionLineListDto
    {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public Session_27.Model.Transaction Transaction { get; set; } = null!;

        public int ServiceTaskId { get; set; }
        public ServiceTask ServiceTask { get; set; } = null!;

        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; } = null!;
    }
}
