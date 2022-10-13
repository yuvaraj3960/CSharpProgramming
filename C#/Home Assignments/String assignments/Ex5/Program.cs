using System;
namespace Equal;
class Program{
    public static void Main(string[] args)
    {
        int i=0,j=0;
        Console.WriteLine("Enter the string:");
        string  str=Console.ReadLine();

        Console.WriteLine("Enter the string:");
        string str1=Console.ReadLine();

       foreach(char c in str)
        {
        
          i+=1;

        }
        Console.WriteLine("The Length of the string : {0}",i);
        foreach(char c in str1)
        {
        
          j+=1;
         

        } Console.WriteLine("The Length of the string : {0}",j);
       

        if (i==j)
        {
            Console.WriteLine("both strings have same length ");
        }
        else
        {
            Console.WriteLine("both strings are not equal");
        }

        if(str.Equals(str1))
        {
            Console.WriteLine("both strings have same value");
        }
        else
        {
            Console.WriteLine("both strings are not equal");
        }






    }
}
