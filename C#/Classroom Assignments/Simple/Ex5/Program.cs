using System;
namespace Income;
class Program{
    public static void Main(string[] args)
    {
        int salary=10000;
        double PA=0.1,HRA=0.1,tax=0.05;
        double salary1=salary+PA+HRA-tax;
        
        double annual=salary1*12;
        Console.WriteLine("Annual Income:"+annual);


    }
}
