using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseSeven
    {

        public void ConvertTemp()
        {
            float celcius = 39.2f;
            float kelvin = celcius +  273.15f;
            float fahrenheit = (celcius * 9 / 5) +32f;


            string temperatureString = string.Format("{0} Celsius euqals to: {1} Kelvin or : {2} Fahrenheit.",
                celcius,kelvin,fahrenheit);

            Console.WriteLine(temperatureString);
        }
    }
}