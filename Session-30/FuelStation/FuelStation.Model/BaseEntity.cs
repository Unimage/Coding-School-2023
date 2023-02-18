using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class BaseEntity {
        public Guid ID { get; }
        public BaseEntity() { 
            ID = Guid.NewGuid();
        }

    }
}
