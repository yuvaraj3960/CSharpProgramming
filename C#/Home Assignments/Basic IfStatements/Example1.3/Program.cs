using System;
namespace Example3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Test Data");
        int data=int.Parse(Console.ReadLine());
        if(data%4==0)
        {
            Console.WriteLine(+data+" "+ "Leap year");
        
        }
        else
        {
            Console.WriteLine(+data +" "+"Not a leap year");
        }
    }
}
