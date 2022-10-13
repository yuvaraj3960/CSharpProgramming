using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        int i;
        int[] arr=new int[5];
        
        
        for( i=0;i<=arr.Length-1;i++)
        {
          Console.WriteLine("element {0}:",i);
           arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(i=0;i<=arr.Length-1;i++)
        {
            Console.WriteLine("element {0} ",arr[i]);
        }
        
    }
}
