using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

         var celcius = TempConverter.FahernheitToCelsius(68);
         var fahernheit = TempConverter.CelsiusToFaherhenit(20);

            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fehernheit {fahernheit}");
            Console.WriteLine();


        }
    }
}
