using System;
namespace Count;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        double sum=0;
        Console.WriteLine("Enter the count:");
        int count=int.Parse((Console.ReadLine()));

        while(i<=count)
        {
             double square=(Math.Pow(i,2));
             sum=sum+square;
             i++;
        }
        Console.WriteLine("output"+" " +sum);
    }
}
