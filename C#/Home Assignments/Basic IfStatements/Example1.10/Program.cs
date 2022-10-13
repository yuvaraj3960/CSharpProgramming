using System;
namespace Password;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the password:");
        string password=Console.ReadLine();

        if (password is "HiTeam")
        {
            Console.WriteLine("Right Password");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }
    }
}
