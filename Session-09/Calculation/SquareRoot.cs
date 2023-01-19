using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_09;

namespace Calculation {
    internal class SquareRoot : Operation {
        public override string Calculate(Expression ex) {

            double varOne; double.TryParse(ex.Values[0], out varOne);
            double result = Math.Sqrt(varOne);
            return result.ToString();
        }
    }
}
