using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.ViewModels {


    //detailed view of a item -> edit/create/info
    public class ItemViewModel {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(6, ErrorMessage = "Max length 6 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string Description { get; set; }
        [Required]
        public ItemType ItemType { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Price [0-99999.99]")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Cost [0-99999.99]")]
        public decimal Cost { get; set; }
    }


    //Baseline view for a item -> list 
    public class ItemListViewModel {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }
}
