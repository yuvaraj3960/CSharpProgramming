using System;
namespace Fibonacci;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number terms:");
        int series=int.Parse(Console.ReadLine());

        int first_term=0,second_term=1,next_term=0,i=3;
        
        
        Console.WriteLine("The number is :"+first_term);
        Console.WriteLine("The number is :"+second_term);
        next_term=first_term+second_term;
        Console.WriteLine("The number is :"+next_term);

        while(i<=series)
        {
            first_term=second_term;
            second_term=next_term;
            next_term=first_term+second_term;
            
            Console.WriteLine("The number is :"+next_term);
            
            i++;
            

        }

    }
}
