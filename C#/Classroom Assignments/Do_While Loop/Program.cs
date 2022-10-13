using System;
namespace checking;
class Program{
    public static void Main(string[] args)
    {
       
        string opinion="";
        
        do
        {
            Console.WriteLine("Enter the number:");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Even number:"+number);
            }
            else
            {
                Console.WriteLine("Odd number:"+number);
            }
            Console.WriteLine("Enter Your opinion:");
            opinion= Console.ReadLine().ToLower();

            if (opinion != "yes" &&  opinion!="no")
            {
                Console.WriteLine(" Invalid input");
                while(opinion!="yes" && opinion!="no")
                {
                Console.WriteLine("Enter Valid input:");
                opinion= Console.ReadLine().ToLower();
                }

            }


           }while(opinion=="yes");   
    }  
}
