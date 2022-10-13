using System;
namespace Example5;
  class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Physics mark:");
        int Physics=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Physics-"+Physics);
        Console.WriteLine("Enter chemistry mark:");
        int chemistry=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("chemistry-"+chemistry);
        Console.WriteLine("Enter maths mark:");
        int maths=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("maths-"+maths);
        int sum = Physics+chemistry+maths;
        Console.WriteLine("Sum-"+sum);
        float percentage= (float)sum/300*100;
        Console.WriteLine("Percentage-" +percentage);


    }
  }
  
