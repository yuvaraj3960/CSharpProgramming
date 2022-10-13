using System;
namespace ByType;


 static void Display(int number)
    {
        Console.WriteLine("Arguments "+number);
    }

    static void Display(string name)
    {
        Console.WriteLine("Arguments: "+name);
    }
    public static void Main(string[] args)
    {
        Display(300);
        Display("Developer");
        Console.ReadLine();
        

    }
