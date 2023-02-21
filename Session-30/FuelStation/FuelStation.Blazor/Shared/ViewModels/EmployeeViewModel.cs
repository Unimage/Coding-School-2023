using FuelStation.Model;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.ViewModels {

    //Detailed info for Employee - > used on edit/create / details
    public class EmployeeViewModel {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = " Max length 20 characters.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max length 20 characters.")]
        public string Surname { get; set; }
        [Required]
        public EmployeeType EmployeeType { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Salary [0-99999.99]")]
        public decimal SallaryPerMonth { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max length 20 characters.")]
        public string username { get; set; }
        [Required]
        [MaxLength(256, ErrorMessage = "Max length 256 characters.")]
        public string password { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public List<TransactionBasicViewModel> Trans { get; set; } = new List<TransactionBasicViewModel>();
    }
}
