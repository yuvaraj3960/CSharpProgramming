using System;
namespace ForLoop;
 class Program{
    public static void Main(string[] args)
    {
       for(int i=0;i<=25;i++)
        {
            if(i%2==0)
            Console.WriteLine("Even numbers are:"+" "+i );
        }
        Console.WriteLine("Enter the Initial value:");
        int Initialvalue=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Final value:");
        int Finalvalue=Convert.ToInt32(Console.ReadLine());
        
        double sum=0;
        for(int j=Initialvalue;j<=Finalvalue;j++)
        {
          double square=(Math.Pow(j,2));
           sum=sum+square;
        }   
        Console.WriteLine("Sum of the Squares:"+sum);
        
    }
 }  
    

    

 
