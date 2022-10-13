using System;
namespace Number;
class Program{
    public static void Main(string[] args)
    {
        int p=1;
        for(int i=1;i<=4;i++,p++)
        {
            for(int j=i+1;j<=4;j++)
            {
                Console.Write(" ");
            }
            for(int j=1;j<i;j++,p++)
            {
                Console.Write(" "+p);
            }
            for (int j=1;j<i-3;j++,p++)
            {
                Console.Write(" "+p);
            }Console.WriteLine(" "+p);
        }
    }
}
