using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Institute
    {
        public Guid ID { get;}
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        { 

        }
        public Institute(Guid id)
        {
            ID = id;
        }
        public Institute(Guid id , string name , int yearsInService)
        {
            ID = id;
            Name = name;
            YearsInService = yearsInService;
        }

        public void GetName()
        {
            //TODO:change to string type and implement and remove get;.
        }
        public void SetName(string name)
        {
            //TODO: implement a set and remove set; from atribute.
        }
    }
}
