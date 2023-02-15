﻿using Session_27.Shared.TransactionLine;
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
        public List<CustomerEditDto> Customers { get; set; } = new();
        public int ManagerId { get; set; }
        public List<ManagerEditDto> Managers { get; set; } = new();
        public int CarId { get; set; }
        public List<CarEditDto> Cars { get; set; } = new();
        public List<Session_27.Model.TransactionLine> TransactionLines { get; set; } = new();
    }
}
