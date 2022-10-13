using System;
namespace Sugar_level;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your sugar level:");
        int level=int.Parse(Console.ReadLine());
        if(level<90)
        {
            Console.WriteLine("Low Sugar");

        }
        if(level>90 && level<130)
        {
            Console.WriteLine("Normal");
        }
        if(level>130 && level<140)
        {
            Console.WriteLine("Medium");
        }
        if(level>140&& level<170)
        {
            Console.WriteLine("Try to  reduce it");
        }
        if(level>170)
        {
            Console.WriteLine("You are very high sugar patient");
        }
    }
}
