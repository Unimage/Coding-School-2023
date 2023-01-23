using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double TotalPrice { get; set; }

        public TransactionLine ()
        { 
        }
        public TransactionLine (Guid id)
        {
            ID = id;
        }
        public TransactionLine(Guid iD, Guid productID, int quantity, double price, double discount, double totalPrice)
        {
            ProductID = productID;
            Quantity = quantity;
            Price = price;
            Discount = discount;
            TotalPrice = totalPrice;
        }
    }
}






    
   

