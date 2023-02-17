using Session_27.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class CarCreateDto {

        
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Brand field can only contain Latin letters ")]
        [Required]
        public string Brand { get; set; }
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "The Model field can only contain Latin letters and digits")]
        [Required]
        public string Model { get; set; }
        [Required]
        [RegularExpression("^[A-Z]{3}[0-9]{4}$", ErrorMessage = "The Registration Code, can only contain 3 Upper Latin letters and 4 digits")]
        public string CarRegistrationNumber { get; set; }
        public string BrandModelNum {
            get {
                return string.Format("{0} {1} {2}", Brand, Model, CarRegistrationNumber);
            }
        }

        // Relations
        public List<Session_27.Model.Transaction> Transactions { get; set; } = new List<Session_27.Model.Transaction>();
    }
}
