using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class EngineerListDto {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int SalaryPerMonth { get; set; }
            public int ManagerId { get; set; }
            public Manager Manager { get; set; } = null!;
    }
    }

