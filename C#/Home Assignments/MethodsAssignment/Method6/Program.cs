using System;
namespace Methods6;
class Program{
    public static void Main(string[] args)
    {
         int i=3;
        int sum=0;
        
        int t1=0,t2=1;
        Console.WriteLine("Enter the number of terms:");
        int terms=int.Parse(Console.ReadLine());
        Console.WriteLine("The number "+t1);
        Console.WriteLine("The number "+t2);
        sum=t1+t2;
        Console.WriteLine("The number  "+sum);

        while(i<=terms)
        {
            
            t1=t2;
            t2=sum;
            sum=t1+t2;
            
            Console.WriteLine("The number "+sum);
            
            i++;
        }
        
    }
}
