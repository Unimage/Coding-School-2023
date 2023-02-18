using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Customer{
        //Attributes
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        //Ctors
        public Customer(){
            ID = Guid.NewGuid();
        }
        //TODO:Relations
    }
}
