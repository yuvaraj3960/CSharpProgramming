using System;
namespace Assign;
class Program{
    public static void Main(string[] args)
    {
        DateTime dob=new DateTime(2021,8,10,10,40,32);
           
        string text=dob.ToString();
        text=dob.ToString("tt");
         
        string[] text1=text.Split(new string[]{"/"," ",":"},System.StringSplitOptions.None);
        
        foreach(string s in text1.Reverse())
        {
            Console.WriteLine(s);
        }
        
    }
}