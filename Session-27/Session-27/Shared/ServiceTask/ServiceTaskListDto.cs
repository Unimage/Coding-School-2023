using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
   public class ServiceTaskListDto
   {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Hours { get; set; }

        public List<Session_27.Model.TransactionLine> TransactionLines { get; set; } = new();

    }












}
