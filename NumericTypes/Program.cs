using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your rectangles length?");
            string lengthOfRectangle = Console.ReadLine();
            Console.WriteLine("What is your rectangles width?");
            string widthOfRectangle = Console.ReadLine();
            int area = int.Parse(lengthOfRectangle) * int.Parse(widthOfRectangle);
            Console.WriteLine("The area of your rectangle is " + area);
        }
    }
}
