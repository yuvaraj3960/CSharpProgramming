
using System;
namespace Addition;
class Program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] arr=new int[2,2];
   

        Console.WriteLine("Enter the elements in an array");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                Console.WriteLine("Elements {0}{1} ",i,j);
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        
       
     
       Console.WriteLine("The elements in an array:");
    
       for(i=0;i<2;i++)
       {
        Console.WriteLine("\n");
        for(j=0;j<2;j++)
        {
        Console.Write("{0}\t",arr[i,j]);
        }Console.Write("\n\n");
       }
       Console.WriteLine("The Transpose of the matrix are");
       for(i=0;i<2;i++)
       {
        Console.WriteLine("\n");
        for(j=0;j<2;j++)
        {
            Console.Write("{0}\t",arr[j,i] );
        }Console.Write("\n\n");
       
    }
}
}
