using System;
namespace Palindrome;
class Program{
    public static void Main(string[] args)
    {
        int i=0,sum=0;
        Console.WriteLine("Enter the text:");
        int value=int.Parse(Console.ReadLine());

        while(i<=2)
        {
            value=value%10;
            sum=sum*10+value;
            value/=10;
            i++;
        }
       
        

        if (sum==value)
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }


    }
}
