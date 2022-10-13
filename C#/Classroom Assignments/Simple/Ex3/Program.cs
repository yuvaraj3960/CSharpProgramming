using System;
namespace Degree;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the celcius:");
        double degree=double.Parse(Console.ReadLine());

        double fahrenheit=degree*(9/5)+32;
        
        Console.WriteLine("Fahrenheit "+fahrenheit);


    }
}
