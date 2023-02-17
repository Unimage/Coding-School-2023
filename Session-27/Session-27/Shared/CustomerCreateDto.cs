using Session_27.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class CustomerCreateDto
{

        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Name field can only contain Latin letters ")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Surname field can only contain Latin letters ")]
        [Required]
        public string Surname { get; set; }
        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
        //[RegularExpression("^\\d{10}$", ErrorMessage = "The Phone field can only contain 10 digits")]
        [Required]
        public int Phone { get; set; }
        [RegularExpression("^\\d{9}$", ErrorMessage = "The Tin field can only contain 9 digits")]
        [Required]
        public string Tin { get; set; }

        // Relations
        public List<Session_27.Model.Transaction> Transactions { get; set; } = new();
    }
}
