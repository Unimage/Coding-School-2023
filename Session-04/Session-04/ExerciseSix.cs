using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseSix
    {

        public void CaclulateSecondsUsingLibraries()
        {
            int seconds = 45678;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            short years = (short)(time.Days / 365);
            string answer = string.Format(seconds + " seconds converts into: " + "{0} years,{1} days,{2} hours,{3} minutes and {4} remaining seconds.",
            years,(long)time.Days - years * 365,time.Hours,time.Minutes,time.Seconds);
            Console.WriteLine(answer);
            Console.WriteLine("Using .Net Libraries this time \n");
        }
    }
}