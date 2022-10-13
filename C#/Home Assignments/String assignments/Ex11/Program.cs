using System;
using System.Collections.Generic;
namespace Duplicate;
class Program{
    public static void Main(string[] args)
    {
        
     
        Console.WriteLine("Enter the string");
        string str=Console.ReadLine();
        string str1="";
       
        
        
        
       /* for(i=0;i<=str.Length;i++)
        {
            for(j=0;j<i;j++)
            {
               if(str[i]==str[j])
               {
                str[index++]=str[i];
               }
                
            }
        
        if(j==i)
        {
            ch[i]=str[i];


        }
        }*/

            
         var unique=new HashSet<char>(str);
         foreach(char c in unique)
         {
            str1+=c;
         }
         Console.WriteLine(str1);


   



    }
    
       
        
}
