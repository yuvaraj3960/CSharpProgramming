using System;
namespace Input;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the username:");
        string str=Console.ReadLine();

        Console.WriteLine("Enter the password");
        string str1=Console.ReadLine();

        if (str=="user" && str1=="pass")
        {
            Console.WriteLine("login successfully");
        }
        else
        {
            Console.WriteLine("login failed");
        }
    }
}
