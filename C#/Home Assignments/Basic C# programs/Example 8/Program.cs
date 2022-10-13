using System;
namespace Example8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the meter:");
        double meter=Convert.ToDouble(Console.ReadLine());
        double cm=meter*100;
        Console.WriteLine("cm"+" "+ cm);
        double Mm=cm*10;
        Console.WriteLine("Mm"+" "+ Mm);
        double inch=39.3*meter;
        Console.WriteLine("inch"+" "+ inch);
        double foot=12*meter;
        Console.WriteLine("foot"+" "+ foot);
        double mile= 0.00062137115277779*meter;
        Console.WriteLine("Miles"+" " + mile);

    }
}
