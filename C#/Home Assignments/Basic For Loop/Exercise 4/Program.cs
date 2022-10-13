using System;
namespace Loop;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number:");
        int value=int.Parse(Console.ReadLine());

        for(int i=1;i<=10;i++)
        {
            int product=value*i;
            Console.WriteLine($"{value}*{i}={product}"); 
        }
    }
}