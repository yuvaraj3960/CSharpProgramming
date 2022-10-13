using System;
namespace Odd;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        Console.WriteLine("Enter the terms:");
        int terms=int.Parse(Console.ReadLine());

        for(int i=1;i<=terms;i++)
        {
            for(int j=1;j<=2*terms;j++)
            {
            if(j%2!=0)
            {
                Console.WriteLine("odd number is "+j);
                sum+=j;
                i++;

            }    
            }  
            }Console.WriteLine(sum);
    }
}
