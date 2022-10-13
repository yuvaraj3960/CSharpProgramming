using System;
namespace Arrays;
class Program{
    public static void Main(string[] args)
    {
        int[,] arr=new int[2,3];
        int[,] arr1=new int[3,2]; 
        int i,j;
        for(i=0;i<=arr.Length-1;i++)
        {
            for(j=0;j<=arr.Length-1;j++)
            {
                Console.WriteLine("elements {0}{1}",i,j);
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
                
            }
        }
        
    }
}
