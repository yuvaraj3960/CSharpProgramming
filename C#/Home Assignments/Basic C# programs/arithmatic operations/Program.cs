using System;
namespace Arithmetic;
  class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2=Convert.ToInt16(Console.ReadLine());
        int sum=number1+number2;
        Console.WriteLine($"{number1} + {number2} = {sum}");
        int subtraction=number1-number2;
        Console.WriteLine($"{number1} - {number2} = {subtraction}");
        int multiplication=number1*number2;
        Console.WriteLine($"{number1} * {number2} = {multiplication}");
        int division=number1/number2;
        Console.WriteLine($"{number1} / {number2} = {division}");
        


    }
  }