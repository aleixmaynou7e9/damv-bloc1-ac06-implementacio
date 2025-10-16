using System;
using System.ComponentModel;
namespace CelsiusToKelvin
{
    public class Program
    {
        public static void Main()
        {
            //The user is prompted to input a temperature in Celsius.
            const string Input = "Enter temperature in Celsius:";
            const string Result = "Temperature in Kelvin:";
            double celsius,kelvin;
            Console.WriteLine(Input);
            celsius = Convert.ToInt32(Console.ReadLine());
            kelvin = (celsius + 273);
            Console.WriteLine(Result, kelvin);
            // 'kelvin' contains the converted temperature, and it is displayed.


        }
    }
}
