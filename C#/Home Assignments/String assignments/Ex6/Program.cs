using System;
namespace Total;
class Program{
    public static void Main(string[] args)
    {
        int i=0,alphabets=0,numbers=0,specialchar=0;
        Console.WriteLine("Enter the string");
        string str=Console.ReadLine();

        while(i<str.Length)
        {
            if((str[i]>='a' && str[i]<='z')||(str[i]>='A' && str[i]<='Z'))
            {
                alphabets++;
            }
            else if(str[i]>='0' && str[i]<='9')
            {
                numbers++;
            }
            else{
                specialchar++;
            }
            i++;

        }
        Console.WriteLine("Number of alphabets in a string "+alphabets);
        Console.WriteLine("Number of numbers in a string "+numbers);
        Console.WriteLine("Number of specialcharacters "+specialchar);
        
    }
}
