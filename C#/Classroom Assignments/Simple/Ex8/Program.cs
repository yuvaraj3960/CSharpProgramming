using System;
namespace Speed;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the speed");
        decimal dec=decimal.Parse(Console.ReadLine());

        if(dec<=10)
        {
            Console.WriteLine("Slow");
        }
        else if(dec>10 && dec<=50)
        {
            Console.WriteLine("Average");

        }
        else if(dec>50 && dec<=150)
        {
            Console.WriteLine("fast");
        }
        else if(dec>150 && dec<=1000)
        {
            Console.WriteLine("Ultra fast");
        }
        else 
        {
            Console.WriteLine("Extermely fast");        
            
        }
    }
}
