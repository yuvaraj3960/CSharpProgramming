using System;
namespace Example2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the age:");
        int age=int.Parse(Console.ReadLine());
        if (age>=18)
        {
            Console.WriteLine("congratulations You are Eligible for casting your voting");

        }
        else
        {
            Console.WriteLine("Not eligible for voting");

        }
    }
}
