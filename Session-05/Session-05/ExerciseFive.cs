using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExerciseFive
    {
        public int[] SortArray(int[] arrayInput)
        {
            for (int i = 0; i < arrayInput.Length - 1; i++)
            {
                for (int j = 0; j < arrayInput.Length - i - 1; j++)
                {
                    if (arrayInput[j] > arrayInput[j + 1])
                    {
                        int temp = arrayInput[j];
                        arrayInput[j] = arrayInput[j + 1];
                        arrayInput[j + 1] = temp;
                    }
                }
            }
            return arrayInput;
        }
    }
}
