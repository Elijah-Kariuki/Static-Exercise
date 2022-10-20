using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"65 degrees Fahrenheit converts to {TempConverter.FahrenheitToCelsius(65)} degrees Celsius");
            Console.WriteLine($"18 degrees Celsius converts to {TempConverter.CelsiusToFahrenheit(18)} degrees Fahrenheit");
        }
    }
}
