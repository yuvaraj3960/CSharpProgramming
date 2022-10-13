using System;
namespace Method7;
class Program{
    public static void Main(string[] args)
    {
        string input="string";
        string  reverse="";

        for(int i=input.Length-1;i>=0;i--)
        {
            reverse+=input[i].ToString();
            

        }
        if(reverse==input)

        {
            System.Console.WriteLine("Palindrome");

        }
        else
        {
            System.Console.WriteLine("Not a Palindrome");
        }

    }
}
