using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace Session_09 {
    public class Expression {
        private int _valueLimit = 2;
        private int _operationLimit = 1;
        int foundOps = 0;
        int foundVars = 0;
        bool isValid;
        bool isSqrt;


        public string[] Values { get; set; }
        public string Operators { get; set; }

        public Expression(string mathExpression) {
            Operators = FindOperationSymbol(mathExpression);
            Values = SplitExpression(mathExpression);
            foundVars = Values.Length;
        }


        // scans expression given and find the operationEnum
        public string FindOperationSymbol(string mathExpression) {

            foreach (var op in mathExpression) {
                if (Enum.IsDefined(typeof(OperationsEnum), (int)op)) {
                    foundOps++;

                    return op.ToString();
                }
                if (op == 's') { isSqrt = true; }
            }
            return string.Empty;
        }

        //find the two variables
        public string[] SplitExpression(string mathExpression) {

            int operationsAmount = Enum.GetNames(typeof(OperationsEnum)).Length;
            char[] delimiters = new char[operationsAmount];
            int index = 0;
            foreach (int op in Enum.GetValues(typeof(OperationsEnum))) {
                delimiters[index++] = (char)op;
            }

            return mathExpression.Split(delimiters);
        }


        // validates string  that has 2 vars and one operator.
        public bool ValidateExpression() {
            bool valid = true;
            if (foundOps > _operationLimit && foundOps > 0) {
                valid = false;
            }

            if ((foundVars != 2)) { valid = false; }
            else if ((foundVars == 1 && !isSqrt)) {
                valid = false;
            }
            return valid;
        }


    }
}
