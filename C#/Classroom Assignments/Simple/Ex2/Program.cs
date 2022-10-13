using System;
namespace Area;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius:");
        float r=float.Parse(Console.ReadLine());

        double area;
        area=Math.PI*r*r;

        double perimeter;
        perimeter=2*Math.PI*r;
        

        Console.WriteLine("Area = "+area);
        Console.WriteLine("perimeter = "+per);
    }
}
