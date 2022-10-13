using System;
namespace Example7;
   class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        int b=Convert.ToInt32(Console.ReadLine()); 
        
        double output= (Math.Pow(a,2))+2*a*b+  (Math.Pow(b,2));
        Console.WriteLine("Output:"+" "+ output);
    }
   }
