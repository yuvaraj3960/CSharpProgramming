using System;
namespace Compare;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int value=int.Parse(Console.ReadLine());

        if(value<100)
        {
            Console.WriteLine("Below 100");
        }
        else if(value>=100 && value<=200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else 
        {
            Console.WriteLine("Greather than 200");
        }
    }
}
