using System;
namespace Addition;
class Program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] arr1=new int[2,2];
        int[,] arr2=new int[2,2];
        int[,] arrsum=new int[2,2];

        Console.WriteLine("Enter the elements in an array");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                Console.WriteLine("Elements {0}{1} ",i,j);
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        
       
       for (i=0;i<2;i++)
       {
        for(j=0;j<2;j++)
        {
            Console.WriteLine("Elements {0}{1} ",i,j);
            arr2[i,j]=Convert.ToInt32(Console.ReadLine());

        }
       }
    
       for(i=0;i<2;i++)
       {
        for(j=0;j<2;j++)
        {
            arrsum[i,j]=arr1[i,j]+arr2[i,j];
        }
       }
       Console.WriteLine("The sum of the matrix are");
       for(i=0;i<2;i++)
       {
        Console.Write("\n");
        for(j=0;j<2;j++)
        {
            Console.Write("{0}\t",arrsum[i,j]);
        }Console.Write("\n\n");
       }

    }
}
