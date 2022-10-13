using System;
namespace Sum;
class Program{
    public static void Main(string[] args)
    {
        int i,sum=0;
        Console.WriteLine("Input elements stored in an array :");
        int size=int.Parse(Console.ReadLine());
        int[] arr = new int[size];
       
        for(i=0;i<=arr.Length-1;i++)
        {
            Console.Write("elements {0} ",i);
            arr[i]=Convert.ToInt32(Console.ReadLine());

        }
        for(i=0;i<=arr.Length-1;i++)
        {
             sum+=arr[i];
        }Console.Write("The sum of an array : " +sum);



    }
}
