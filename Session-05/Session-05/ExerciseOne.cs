using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseOne
    {
        public string ReverseString(String inputString)
        {
            if (inputString == null)
            {
                return string.Empty;
            }
            string reversedString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
                
            }
            return reversedString;

        }
    }
}
