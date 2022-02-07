using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahernheitToCelsius (double farernheit)
        {
          var result = (farernheit - 32) / 1.8;

            return result;
        }
            public static double CelsiusToFaherhenit (double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
