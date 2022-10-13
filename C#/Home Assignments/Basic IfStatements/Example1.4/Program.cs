using System;
namespace Greatest;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        int number3=int.Parse(Console.ReadLine());
        if (number1>number2)
        {
            if (number1>number3)
            {
                Console.WriteLine("1nd number is the greatest among three");
                
            }
            else
            {
                Console.WriteLine("3rd number is the greatest among three");
            }
        }
        else if(number2>number3)
        {
            Console.WriteLine("2nd number is the greatest among three");
        }
        else
        {
            Console.WriteLine("3rd number is the greatest among three");

        }
    }

}
