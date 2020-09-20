using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dana";
            string location = "Meridian, ID";
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am from {location}.");
            Console.WriteLine($"Today's date is {currentDate.Date.ToString("d")}.");
            //Christmas
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            Console.WriteLine($"There are {(christmas - currentDate).Days} days until Christmas");
            //Yellowbook code example
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
