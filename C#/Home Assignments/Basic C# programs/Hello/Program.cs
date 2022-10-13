using System;
namespace Hello;

   class Program
   {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Name:");
        string name= Console.ReadLine();
        Console.WriteLine("Enter the greetings:");
        string greetings=Console.ReadLine();
        Console.WriteLine(greetings  +" "+  name);
        Console.WriteLine("{0} {1}" ,greetings,name);
        Console.WriteLine($"{greetings} {name}");


        

   }
   }
       
