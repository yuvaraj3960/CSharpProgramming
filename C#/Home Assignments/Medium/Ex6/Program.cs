using System;
namespace Leapyear;
class Program{
    public static void Main(string[] args)
    {
        int i=1;
        Console.WriteLine("enter the number ");
        int value=int.Parse(Console.ReadLine());

        while(i<=value)
        {
            if(i%4==0)
            {
                Console.WriteLine("Leap year "+i);
            }
           i++;
        }
    }
}
