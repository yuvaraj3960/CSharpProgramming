using System;
namespace Example6;
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the price :");
            int price=Convert.ToInt32(Console.ReadLine());
            double Total=(double)price+price*0.18;
            Console.WriteLine("Total"+" "+Total);

            
        }

    }
