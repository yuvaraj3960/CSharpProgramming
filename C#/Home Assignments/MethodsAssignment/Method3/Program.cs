using System;
namespace Method3;
class Program{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the value");
       int value1=int.Parse(Console.ReadLine());

       Console.WriteLine("Enter the value");
       int value2=int.Parse(Console.ReadLine());

       Swap(value1,value2);
    }
    public static  void  Swap(int a,int b)
    {
        int temp;
        temp=a;
        a=b;
        b=temp;
        Console.WriteLine(a);
        
        Console.WriteLine(b);

    }
}
