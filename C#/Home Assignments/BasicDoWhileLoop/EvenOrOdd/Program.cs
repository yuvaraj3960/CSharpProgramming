using System;
namespace EvenOrOdd;
class Program{
    public static void Main(string[] args)
    {
        string condition="yes";
        do
        {
            System.Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                System.Console.WriteLine("Even Number");
            }
            else
            {
                System.Console.WriteLine("Odd Number");
            }
            System.Console.WriteLine("Do you want to continue the process");
            condition=Console.ReadLine();
        }while(condition=="yes");
    }
}
