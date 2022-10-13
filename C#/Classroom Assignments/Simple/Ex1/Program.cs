using System;
namespace Inches;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number :");
        double number =double.Parse(Console.ReadLine());

        double cms=number*2.54;
        Console.WriteLine("The centimeters  "+cms);


    }
}
