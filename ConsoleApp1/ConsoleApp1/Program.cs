using System;
using System.ComponentModel;
namespace RectangleArea
{
    public class Program
    {
        public static void Main()
        {
            //The user is prompted to input the width and height of a rectangle.
            const string Input_Width = "Enter the width of the rectangle:";
            const string Input_Height = "Enter the height of the rectangle:";
            const string Result = "The area of the rectangle is:";
            double width,height,area;
            Console.WriteLine(Input_Width);
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Input_Height);
            height = Convert.ToInt32(Console.ReadLine());
            area = (width*height);
            Console.WriteLine(Result, area);
            // 'area' contains the product of 'width' and 'height', and it is displayed.



        }
    }
}
