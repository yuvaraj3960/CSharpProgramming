using System;
namespace Palindrome;
class Program{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Enter the string:");
        //string str=Console.ReadLine();
        int i;
        string str="ten";
        string str1="";

        for(i=str.Length-1;i>=0;i--)
        {
            str1+=str[i];
        }
        if(str1==str)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }
        

    
       
    }
}

