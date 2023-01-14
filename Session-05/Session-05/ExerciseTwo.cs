using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseTwo
    {
        public int Calculate(int inputNumber, int function)
        {
            int result = 0;
            if (function == 1)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    result += i;
                }
            }
            else
            {
                result = 1;
                for(int i=1; i<= inputNumber; i++)
                {
                    result *= i;
                }

            }
        return result;
        }

    }
}
