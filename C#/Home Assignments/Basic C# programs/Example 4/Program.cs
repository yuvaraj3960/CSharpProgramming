using System;
namespace Example4;
  class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the raduis of a Cylinder:");
        int raduis=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of a Cylinder:");
        int height=Convert.ToInt32(Console.ReadLine());
        double Volume= (double)3.14*(Math.Pow(raduis,2))*height;
        Console.WriteLine("Volume :"+Volume);

            }
  }
