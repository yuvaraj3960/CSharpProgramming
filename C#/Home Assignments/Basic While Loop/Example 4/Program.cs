using System;
namespace Valid;
class Program{
    public static void Main(string[] args)
    {
        
        int value;
        bool number;
        
         Console.WriteLine("Enter the number:");
         number  = int.TryParse(Console.ReadLine(),out value);
        
         int value1=Convert.ToInt32(Console.ReadLine());
         if(value1<5)
         {

         Console.WriteLine("valid Input");
         
         }
         else if(value1>5)
         {
            Console.WriteLine("Invalid input");
         }
         
        else
        {
        while(number!=true)
         {
            Console.WriteLine("Invalid input");
             Console.WriteLine("Enter the number:");
             number  = int.TryParse(Console.ReadLine(),out value);
            
         }

         Console.WriteLine("The output "+number);
        }
    }
}
