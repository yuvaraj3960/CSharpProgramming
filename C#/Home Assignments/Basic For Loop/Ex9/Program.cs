using System;
namespace Pattern;
class Program{
    public static void Main(string[] args)
    {
        int i,j;
        
        
        for(i=1;i<=4;i++)
        {
            for( j=i+1;j<=4;j++)
            {
                Console.Write("*");
            }
        }
    }
}
