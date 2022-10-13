using System;
namespace Vowel;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the characters:");
        char charr=char.Parse(Console.ReadLine().ToLower());
        if(charr=='a' && charr=='e' && charr=='i' && charr=='o' && charr=='u')
        {
            Console.WriteLine("it is vowel");
        }
        else
        {
            Console.WriteLine("not a vowel");
        }

    }
}
