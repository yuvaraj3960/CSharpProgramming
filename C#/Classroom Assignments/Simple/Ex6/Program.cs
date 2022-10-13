using System;
namespace Validate;
class Program{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Enter the password:");
        string str=Console.ReadLine();

        if(str=="s3cr3t!P@sswOrd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong Password");
        }
    }   
}
