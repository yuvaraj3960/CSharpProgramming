using System;
namespace Words;
class Program{
    public static void Main(string[] args)
    {
        int i;
        Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        
        string[] s=str.Split(new char[]{' ',';','.',':'});

        foreach(string s1 in s)
        {
           Console.WriteLine($"Substring: {s1}");  

        }   
                   }
    
}
