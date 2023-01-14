using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExerciseThree
    {
        public int[] MultiplyArray(int[] arrayOne, int[] arrayTwo)
        {
            int[] resultArray = new int[arrayOne.Length * arrayTwo.Length];
            int counter = 0;
            for(int i =0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    resultArray[counter] = arrayOne[i] * arrayTwo[j];
                    counter++;
                }
            }
            return resultArray;
        }
    }
}
