using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseFive
    {

        public void CaclulateSeconds()
        {
            int seconds = 45678;
            short years = (short)(seconds / (60 * 60 * 24 * 365));
            short days = (short)((seconds / (60 * 60 * 24)));
            short hours = (short)((seconds / (60 * 60)));
            short minutes = (short)((seconds/60));
           

            Console.WriteLine(seconds + " seconds are: " + +years + " years, " + days + " days, " + hours + " hours and " + minutes + " minutes.\n");
        }
    }
}