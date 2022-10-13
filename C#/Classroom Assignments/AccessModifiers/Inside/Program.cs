using System;
namespace Inside;

class Program{
    public static void Main(string[] args)
    {
        First one = new First();
        Console.WriteLine(one.PublicNumber);
         Console.WriteLine(one.PrivateNumber);
         Console.WriteLine(one.InternalNumber);
        Second two=new Second();
        Console.WriteLine(two.ProtectedNumberOutput);
        Console.WriteLine(two.ProtectedinternalNumber);
    }
}
