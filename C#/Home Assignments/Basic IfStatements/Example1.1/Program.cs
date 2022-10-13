using System;
namespace Example1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Test data");
        int data=int.Parse(Console.ReadLine());
        if(data%2==0)
        {
            Console.WriteLine(+data+" "+ "is an even number");
        }
        else
        {
            Console.WriteLine(+data+" "+ "is an odd number");


        }
    }

}

