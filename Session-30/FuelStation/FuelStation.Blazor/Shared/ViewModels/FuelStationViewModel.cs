using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.ViewModels {
    public class FuelStationViewModel {
        public Guid ID { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Rent Range [0-99999.99]")]
        public decimal MonthlyRentCost { get; set; }
    }
}
