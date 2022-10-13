using System;
namespace Percentage;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test Data:");
        Console.WriteLine("Enter the physics mark");
        int physics=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the chemistry mark");
        int chemistry=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the mathematics mark");
        int mathematics=int.Parse(Console.ReadLine());
        double sum=physics+chemistry+mathematics;
        double Percentage=sum/300*100;    
        if (Percentage>=75)
        {
            Console.WriteLine("The candidate is Eligible for admission");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission");
        }
        }
}
