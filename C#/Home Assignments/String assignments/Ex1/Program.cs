using System;
namespace Length;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();

        foreach(char c in str)
        {
        
          i+=1;

        }
        Console.Write("The Length of the string : {0}",i);


    }
}



