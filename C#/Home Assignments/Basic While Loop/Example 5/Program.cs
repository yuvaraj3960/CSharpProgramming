using System;
namespace Sum;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        int sum=0;
        
       
        int number=0;
        while(i<3)
        {
            Console.WriteLine("Enter the number:");
             number=int.Parse(Console.ReadLine());
            sum+=number;
            i++;
        }
        Console.WriteLine($"Sum of the digits {number}{number}{number} is {sum}");
    }
}
