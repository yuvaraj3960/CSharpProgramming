using System;
namespace Seperate;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        Console.WriteLine("Enter the string");
        string str=Console.ReadLine();
        Console.WriteLine("The characters are :");
        while(i<=str.Length-1)

        {
            Console.Write("  {0}",str[i]);
            i++;

        }Console.Write("\n\n");
    }
}
