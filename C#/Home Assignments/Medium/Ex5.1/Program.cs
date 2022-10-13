using System;
namespace Matrix;
class Program{
    public static void Main(string[] args)
    {
        int[,,] arr=new int[3,3,3];
        int[,,] arr1=new int[3,3,3];
        int[,,] sum=new int[3,3,3];
        int i,j,k;
        
        
        for (i=0;i<=arr.Length-1;i++)
        {
            for(j=0;j<=arr.Length-1;i++)
            {
                for(k=0;k<=arr.Length-1;k++)
                {
                Console.WriteLine($"elements {i}{j}{k}");
                arr[i,j,k] = Convert.ToInt32(Console.ReadLine());
                }

            }
        }
            for (i=0;i<=arr1.Length-1;i++)
        {
            for(j=0;j<=arr1.Length-1;i++)
            {
                for(k=0;k<arr.Length-1;k++)
                {
                Console.WriteLine($"elements {i}{j}{k}");
                arr[i,j,k] = Convert.ToInt32(Console.ReadLine());
                }

            }
        }
            for (i=0;i<=arr.Length-1;i++)
        {
            for(j=0;j<=arr.Length-1;i++)
            {
                for(k=0;k<arr.Length-1;k++)
                {

                sum[i,j,k]=arr[i,j,k]+arr1[i,j,k];
                }
                

            }
        }
        Console.WriteLine("sum of an array:");
           for (i=0;i<=arr.Length-1;i++)
        {
            for(j=0;j<=arr.Length-1;i++)
            {
                for(k=0;k<arr.Length-1;k++)
                {
               Console.WriteLine("{0}\t",sum[i,j,k]);
            }
            }Console.Write("\n\n");
        }  
        

    }
}
