using System;
namespace Sum;
class Program{
    public static void Main(string[] args)
    {
        int sum;
        Console.WriteLine("Enter The numbers:");
        int numbers=int.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
            
            sum=numbers+0;
            Console.WriteLine("Sum is "+" "+sum);
            double average=(double)sum/10;
            Console.WriteLine("Average is"+" "+average);
            break;

        }
    }
}
