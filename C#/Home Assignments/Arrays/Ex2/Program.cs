using System;
namespace Print;
class Program{
    public static void Main(string[] args)
    {
        int n,i;
        Console.WriteLine("Enter the size of an array:");
         n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for( i=0;i<=arr.Length-1;i++)
        {
            Console.WriteLine("elements {0}",i);
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }  
        Console.Write("The elements in an array :"); 
         for(i=0;i<=arr.Length-1;i++)
         {
            Console.Write(" {0}",arr[i]);
         }Console.Write("\n");
          Console.Write("The reverse array :");
         for(i=arr.Length-1;i>=0;i--)
         {
            Console.Write( " {0}",arr[i]);
         }Console.Write("\n");
         
         }
}
