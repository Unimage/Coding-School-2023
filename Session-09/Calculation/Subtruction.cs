using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_09;

namespace Calculation {
    public class Subtruction:Operation {

        public override string Calculate(Expression ex) {

            decimal varOne; decimal.TryParse(ex.Values[0], out varOne);
            decimal varTwo; decimal.TryParse(ex.Values[1], out varTwo);
            decimal result = varOne - varTwo;
            return result.ToString();
        }
    }
}
