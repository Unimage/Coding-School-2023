using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared
{
    public class CarListDto {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string BrandModelNum {
            get {
                return string.Format("{0} {1} {2}", Brand, Model, CarRegistrationNumber);
            }
        }

        // Relations
        public List<Session_27.Model.Transaction> Transactions { get; set; }
    }
}
