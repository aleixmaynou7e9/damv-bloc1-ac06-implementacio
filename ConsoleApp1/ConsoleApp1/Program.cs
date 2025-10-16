using System;
namespace HelloWorldProject
{
    public class HelloWorld
    {
        public static void Main()
        {
            //The user is prompted to input two integers.
            const string Input1 = "Enter the first integer:";
            const string Input2 = "Enter the second integer:";
            const string Result = "The sum is:";
            int num1,num2,sum;
            Console.WriteLine(Input1);
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Input2);
            num2=Convert.ToInt32(Console.ReadLine());
            sum = (num1 + num2);
            Console.WriteLine(sum);
            //'sum' contains the sum of 'num1' and 'num2', and it is displayed.

        }
    }
}
