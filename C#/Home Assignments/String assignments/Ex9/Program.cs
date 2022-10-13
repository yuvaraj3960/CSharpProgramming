using System;
namespace Check;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();

        Console.WriteLine("enter the input:");
        string str1=Console.ReadLine();
       // int res=(str,str1);
        
        if(str.Contains(str1)) 
        {
            Console.WriteLine("string exists");
        }  
        else{
            Console.WriteLine("string doesn't exists");
        } }
}