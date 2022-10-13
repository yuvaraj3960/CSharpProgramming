using System;
namespace Currencies;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the money in rupees");
        double rupees=double.Parse(Console.ReadLine());

        double USD=rupees/81.5;
        Console.WriteLine(USD);

        double EUR=(double)rupees/78.8;
        Console.WriteLine(EUR);

        double CNY=(double)rupees/11.37;
        Console.WriteLine(CNY);
    }
}
