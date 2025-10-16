using System;
using System.ComponentModel;
namespace EuroToDollar
{
    public class Program
    {
        public static void Main()
        {
            //The user is prompted to input an amount in euros.
            const double ExchangeRate = 1.12;
            const string Input = "Enter amount in euros:";
            const string Result = "Amount in dollars:";
            double euros,dollars;
            Console.WriteLine(Input);
            euros = Convert.ToDouble(Console.ReadLine());
            dollars = (euros*ExchangeRate);
            Console.WriteLine(Result, dollars);
            // 'dollars' contains the converted amount, and it is displayed.



        }
    }
}
