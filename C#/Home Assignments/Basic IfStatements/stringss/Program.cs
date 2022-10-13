using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        int count=0;
        Console.WriteLine("Enter the Main String ");
        string text=Console.ReadLine();

        Console.WriteLine("Enter the string for searching");
        string text1=Console.ReadLine();

        string[] str=text.Split(new string[] {text1},StringSplitOptions.None);
        foreach(string s in str)
        {
           
          Console.WriteLine(s);
          count++;
          
          
       
        
        
        }   
        count-=1;
        Console.WriteLine("The count is "+count);     


    }
}

