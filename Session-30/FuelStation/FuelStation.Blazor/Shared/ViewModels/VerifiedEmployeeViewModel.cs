using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.ViewModels {
    public class VerifiedEmployeeViewModel {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
