using System;
namespace Power;
class Program{
    public static void Main(string[] args)
    {
        
        for(int i=0, p=1;i<=6;i++,p++)
        {
            for(int j=0;j<=i;j++,p++)
            {
                Console.WriteLine(p++);
            }
        }
    }
}
