using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class ProductCategory
    {
        
        public Guid ProductCategoryID { get; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ActionEnum Action { get; set; }


        public ProductCategory()
        {
            ProductCategoryID = Guid.NewGuid();
        }

    }
}