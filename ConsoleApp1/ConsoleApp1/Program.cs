using System;
using System.ComponentModel;
namespace AverageThreeNumbers
{
    public class Program
    {
        public static void Main()
        {
            //The user is prompted to input three real numbers.
            const string Input1 = "Enter the first number:";
            const string Input2 = "Enter the second number:";
            const string Input3 = "Enter the third number:";
            const string Result = "The average is:";
            double num1,num2,num3,average;
            Console.WriteLine(Input1);
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Input1);
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Input1);
            num3 = Convert.ToDouble(Console.ReadLine());
            average = (num1+num2+num3)/3;
            Console.WriteLine(Result, average);
            // 'average' contains the arithmetic mean of the three numbers, and it is displayed.



        }
    }
}
