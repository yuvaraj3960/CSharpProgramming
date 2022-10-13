using System;
namespace Prime;
class Program{
    public static void Main(string[] args)
    {
        int j=2,t=0;
        Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        
        
    
        while(j<=number/2)
         {
           if(number%j==0)
                {
                    t=1;
                }
                j++;
         }
         if(t==1)  
         {
            Console.WriteLine("prime number"+number);
         }

         else{
                    Console.WriteLine("Not a Prime number"+number);
                    
                }

          }
        }

    

