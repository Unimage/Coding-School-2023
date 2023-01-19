using Session_09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    internal class Calc {

        public Calc() {

        }

        public string Calculate(string input) {
            Expression ex = new Expression(input);
            Operation operation;
            if (!ex.ValidateExpression()) {
                return "Error";
            }
            var op = (OperationsEnum)Convert.ToChar(ex.Operators);
            switch (op) {
                case OperationsEnum.Plus:
                    operation = new Addition();
                    break;
                case OperationsEnum.Minus:
                    operation = new Subtruction();
                    break;
                case OperationsEnum.Multiplication:
                    operation = new Multiplication();
                    break;
                case OperationsEnum.Division:
                    operation = new Divition();
                    break;
                case OperationsEnum.Power:
                    operation = new Power();
                    break;
                case OperationsEnum.SquareRoot:
                    operation = new SquareRoot();
                    break;
                default:
                    return "Error";
            }
        }
    }
}
