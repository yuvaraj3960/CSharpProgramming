using System;
namespace Ddtt;
class Program{
    public static void Main(string[] args)
    {
        DateTime dd=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(dd.Year);
        Console.WriteLine(dd.Month);
        Console.WriteLine(dd.Day);
        Console.WriteLine(dd.Hour);
        Console.WriteLine(dd.Minute);
        Console.WriteLine(dd.Second);
        

         Console.WriteLine(dd.ToString("tt"));
         string text=dd.ToString();
         
         
        
         string[] text1=text.Split(new string[]{"/"," ",":"},System.StringSplitOptions.None);
         
        foreach(string s in text1.Reverse())
        {
            
            Console.WriteLine(s);
        }
        Console.WriteLine("yyyy/MM/dd hh:mm:ss");
        string test=Console.ReadLine();
        string[] test1=test.Split(new string[]{"/"," ",":"},System.StringSplitOptions.None);
        Console.WriteLine(test1[0]);

    }
}
