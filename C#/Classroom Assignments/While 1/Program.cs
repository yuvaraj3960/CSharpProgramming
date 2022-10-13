using System;
namespace While;
class Program{
    public static void Main(string[] args)
    {
       /*int i=0;
        while(i<=25)
        { 
            if (i%2==0)
              {
                Console.WriteLine(i);
                
              }
            i++;
        }*/
        int number;
        Console.WriteLine("Enter the number input");
        bool input= int.TryParse(Console.ReadLine(),out number);
       
        

        while(input!=true)
        {
          Console.WriteLine("Invalid input format.Please enter the valid input format");
          bool input1=int.TryParse(Console.ReadLine(),out number);
          input=input1;       
        }
        Console.WriteLine("The Valid number is"+" "+number);


    }
}
