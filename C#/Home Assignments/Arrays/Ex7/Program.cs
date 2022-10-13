using System;
namespace Twodimensional;
class Program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] arr=new int[3,3];

        Console.WriteLine("Enter the elements in an array");
        for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                Console.WriteLine("Elements {0}{1} ",i,j);
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix element is ");
        for(i=0;i<3;i++)
        {
            Console.Write("\n");
            for(j=0;j<3;j++)
            {
                Console.Write("{0}\t",arr[i,j]);
            }Console.Write("\n\n");
        }    }
}
