using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseThree
    {

        public void MathOperations()
        {
            Console.WriteLine(-1 + 5 * 6);
            Console.WriteLine(38 + 5 % 7);
            Console.WriteLine(14 + (-3 * 6) / (float)7);
            Console.WriteLine(2 + (13 / (double)6) * 6 + Math.Sqrt(7));
            Console.WriteLine((Math.Pow(6, 4) + Math.Pow(5, 7)) / (float)(9 % 4) + "\n");
        }
    }
}