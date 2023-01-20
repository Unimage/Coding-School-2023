using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Institute {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute() {
            ID = Guid.NewGuid();
        }

        public Institute( string name, int yearsInService) {
            ID = Guid.NewGuid();
            Name = name;
            YearsInService = yearsInService;
        }
        public void GetName() {
            //TODO:change to string type and implement and remove get;.
        }
        public void SetName(string name) {
            //TODO: implement a set and remove set; from atribute.
        }
    }
}
