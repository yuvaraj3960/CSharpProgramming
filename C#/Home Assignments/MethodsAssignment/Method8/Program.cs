using System;
namespace Method8;
class Program{
    public static void Main(string[] args)
    {
        
        GetMarks();
        
        
    }
    public static void GetMarks()
    {
        System.Console.WriteLine("Enter your maths mark");
        int maths=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Physics mark");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry mark");
        int chemistry=int.Parse(Console.ReadLine());
        CalculatePercentage( maths, physics, chemistry);

    }
    public static void CalculatePercentage(int maths,int physics,int chemistry)
    {
        double average=(maths+physics+chemistry)/3;
        double percentage=average*100/3;
        System.Console.WriteLine("Percentage "+percentage);

    }
}
