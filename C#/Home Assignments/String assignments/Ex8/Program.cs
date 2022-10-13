using System;
namespace Extract;
class Program{
    public static void Main(string[] args)
    {
        int i=0,length;
        char[] arr1;
        Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        length=str.Length;
        arr1=str.ToCharArray(0,length);
        Console.WriteLine("Enter the input for extraction");
        int count=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of a substring:");
        int count1=int.Parse(Console.ReadLine());
        Console.WriteLine("the sub string is ");
        while(i<count1)
        {
            Console.Write(arr1[count+i-1]);
            i++;
           
        }Console.Write("\n\n");


    }
}
