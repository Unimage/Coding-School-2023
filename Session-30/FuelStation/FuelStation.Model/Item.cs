using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Item {
        //Attributes
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //Ctor
        public Item() {
            ID= Guid.NewGuid();
        }
        //Item Relations : Item - TransactionLine -> 1-N
        List<TransactionLine> TransactionLines { get; set; }=new List<TransactionLine>();
    }
}
