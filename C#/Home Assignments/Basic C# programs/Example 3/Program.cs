using System;
namespace Example;
   class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the celsius:");
        int celsius=Convert.ToInt32(Console.ReadLine());
        int kelvin=celsius+273.15;
        Console.WriteLine("Kelvin = "+ kelvin);
        int fahrenheit=(celsius*9/5)+32;
        Console.WriteLine("Fahrenheit = "+fahrenheit);
    }
   }
