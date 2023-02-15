using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class CustomerCreateDto
{

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Tin { get; set; }

        // Relations
        public List<Session_27.Model.Transaction> Transactions { get; set; } = new();
    }
}
