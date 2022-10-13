using System;
namespace Method4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms");
        int terms=int.Parse(Console.ReadLine());
        Fibonacci(terms);
    }
    public static void Fibonacci(int n)
    {
        int temp;
        int a=0,b=1,i=3,sum=0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        sum=a+b;
        Console.WriteLine(sum);
        while(i<n)
        {
            
            a=b;
            b=sum;
            
            
            sum=a+b;

            Console.WriteLine(sum);
            i++;
            



            
        }
    
        

    }
}
