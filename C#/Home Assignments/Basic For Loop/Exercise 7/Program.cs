using System;
namespace Pattern1;
class Program{
    public static void Main(string[] args)
    {
        for(int i=1;i<=4;i++)
        {
            for(int j=i+1;j<=4;j++)
            {
                Console.Write(" ");
            }
            for (int j=1;j<i;j++)
            {
                Console.Write("*");
            }
            for (int j=1;j<i;j++){
                Console.Write("*");
            }Console.WriteLine("*");
        }
    }
}

