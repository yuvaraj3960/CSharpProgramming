using System;
namespace SumOFNaturalNumbers;
class Program{
    public static void Main(string[] args)
    {
        string condition="yes";
        int sum=0;
        do{
        System.Console.WriteLine("Enter the number");
        int number1=int.Parse(Console.ReadLine());

        sum+=number1;
        System.Console.WriteLine("sum is "+sum);

        System.Console.WriteLine("Do you want to continue the process");
        condition=Console.ReadLine();
        }while(condition=="yes");

    }
}
