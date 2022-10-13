using System;
namespace Vowel;
class Program{
    public static void Main(string[] args)
    {
        int i,vowels=0,consonants=0;
        Console.WriteLine("enter the string");
        string str=Console.ReadLine();
         
        for(i=0;i<str.Length;i++)
        {
            if  (str[i]=='a'||str[i]=='A'||
                str[i]=='e'||str[i]=='E'||
                str[i]=='i'||str[i]=='I'||
                str[i]=='o'||str[i]=='O'||
                str[i]=='u'||str[i]=='U')
                {
                    vowels++;

                }
                else if ((str[i]>='a' && str[i]<='z')||(str[i]>='A' && str[i]<='Z'))
                {
                    consonants++;
                }

                }
                Console.WriteLine("total number of vowels "+vowels);
                Console.WriteLine("total number of consonants "+consonants);
        }
    }

