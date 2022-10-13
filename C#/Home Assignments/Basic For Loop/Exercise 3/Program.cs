using System;
namespace cube;
class Program{
    public static void Main(string[] args)
    {
        double cube;
        Console.WriteLine("Enter the number of terms");
        int terms=int.Parse(Console.ReadLine());
        for(int i=1;i<=terms;i++)
        {
            cube=(Math.Pow(i,3));
            Console.WriteLine($"The Number is {i} and The cube is {cube}");
        }
    }
}
