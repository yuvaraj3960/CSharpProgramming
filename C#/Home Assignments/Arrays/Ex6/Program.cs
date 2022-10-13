using System;
namespace Even;
class Program{
    public static void Main(string[] args)
    {
         int n,i,j=0,k=0;
        Console.WriteLine("Enter the size of an array:");
         n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for( i=0;i<=arr.Length-1;i++)
        {
            Console.WriteLine("elements {0}",i);
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }  
        int[] even = new int[10];
       /* for(j=0;j<=even.Length-1;j++)
        {
            
        }*/
        int[] odd = new int[10];
       /* for(k=0;k<=odd.Length-1;k++)
        {
          Console.ReadLine(odd[k]);
        }*/
        
        Console.Write("The elements in an array :"); 
         for(i=0;i<=arr.Length-1;i++)
         {
            Console.Write(" {0}",arr[i]);
         }Console.Write("\n");
        
          
        for(i=0;i<=arr.Length-1;i++)
        {
         
            //Console.Write("Even numbers are:");
            if(arr[i]%2==0)
            {
                
                
                {
                 even[j]=arr[i];
                 j++;
                 
                 
                 
                 
                 
                }
                
               

            }
            
            else 
            {
                
            
                odd[k]=arr[i];
                k++;
               
                
            } 
            }
            Console.Write("\nEven Number is ");
            for(i=0;i<j;i++)
            {
                Console.Write(" {0}",even[i]);
            }
            Console.Write("\nOdd Number is ");
            for(i=0;i<k;i++)
            {
                Console.Write(" {0}",odd[i]);
            }Console.Write("\n\n");
         }
         
        
         
}        
        // Console.Write("Odd numbers are:");
       
    

