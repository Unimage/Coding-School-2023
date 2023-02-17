using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_27.Model;
namespace Session_27.Shared
{
    public class ServiceTaskCreateDto
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        [Required]
        [RegularExpression("^\\d+(\\.\\d+)?$", ErrorMessage = "The Hours field can only contain a decimal number")]
        public decimal Hours { get; set; }
        public List<CarListDto> Cars { get; set; } = new();
        public List<Session_27.Model.TransactionLine> TransactionLines { get; set; } = new();

    }



}
