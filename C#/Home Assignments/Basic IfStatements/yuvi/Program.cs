using System;
namespace Assignment;
class Program{
    public static void Main(string[] args)
    {
        DateTime dob=new DateTime(2021,8,10,10,40,32);
        
        Console.WriteLine(dob.Year);
        Console.WriteLine(dob.Month);
        Console.WriteLine(dob.Day);
        Console.WriteLine(dob.Hour);
        Console.WriteLine(dob.Minute);
        Console.WriteLine(dob.Second);
        

        
         
       {
        Console.WriteLine(dob.ToString("tt"));
       }
        string text=dob.ToString();
         
         
        string[] text1=text.Split(new string[]{"/"," ",":"},System.StringSplitOptions.None);
        
        
        foreach(string s in text1.Reverse())
        {
            Console.WriteLine(s);

        }

        



        Console.WriteLine("yyyy/MM/dd hh:mm:ss");
        string test=Console.ReadLine();
        string[] test1=test.Split(new string[]{"/"," ",":"},System.StringSplitOptions.None);
        Console.WriteLine("year" +test1[0]);
        Console.WriteLine("month" +test1[1]);
        Console.WriteLine("day" +test1[2]);
    }
}
