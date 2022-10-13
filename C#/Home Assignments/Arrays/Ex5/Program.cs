using System;
namespace Ascending;
class Program{
    public static void Main(string[] args)
    {
        int n,i,j,temp=0;
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

         for(i=0;i<=arr.Length-1;i++)
         {
            for(j=i+1;j<=arr.Length-1;j++)
            {
                if(arr[i]>arr[j])
                {
                temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
                }


            }
         }
         Console.Write("The ascending oder ");
          foreach(var t in arr)
          {
            Console.Write( " "+t);
          }

    }
}

