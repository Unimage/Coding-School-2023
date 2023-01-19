using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_09;

namespace Calculation {
    internal class Power:Operation {
        public override string Calculate(Expression ex) {

            double varOne; double.TryParse(ex.Values[0], out varOne);
            double varTwo; double.TryParse(ex.Values[1], out varTwo);
            double result = Math.Pow(varOne, varTwo);
            return result.ToString();
        }
    }
}
