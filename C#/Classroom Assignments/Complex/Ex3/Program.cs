using System;
namespace Anagram;
class Program{
    public static void Main(string[] args)
    {
        int i,j,r=0;
        string str="tni";
        char[] chars=str.ToCharArray();
        string str1="int";
        char[] char1=str1.ToCharArray();
        for(i=0;i<=chars.Length-1;i++)
        {
            for(j=0;j<=char1.Length-1;j++)
            {
                if(chars[i]==(char1[j]))
                {
                   r+=1;
                }
                else
                {
                    r=0;
                    
                }
            }
        }
        if(r==str.Length)
        {
            Console.WriteLine("Anagram");
        }
        else
        {
        Console.WriteLine("Not an Anagram");
        }

    }
}
