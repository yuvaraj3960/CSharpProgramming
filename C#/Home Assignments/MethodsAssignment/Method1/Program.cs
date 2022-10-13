using System;
namespace  Method1;
class Program{
    public static void Main(string[] args)
    {
        string condition;
        Console.WriteLine("1.Addition:");
        Console.WriteLine("2.substraction:");
        Console.WriteLine("3.Multiplication:");
        Console.WriteLine("4.Division:");

        

       
         
        do
        {
            Console.WriteLine("Enter your option:");
            int option=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value1:");
            int value1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value1:");
            int value2=int.Parse(Console.ReadLine());

            
          switch(option)
           {
              case 1:
                {
                
                    Console.WriteLine("The sum of two numbers "+Addition(value1,value2));
                    
                }break;
            
              case 2:
                {
                   Console.WriteLine("The Substraction of two numbers "+Subtraction(value1,value2)); 
                    
                }break;
              case 3:
                {
                     Console.WriteLine("The Multiplication of two numbers "+Multiplication(value1,value2)); 
                    
                }break;
              case 4:
                {
                Console.WriteLine("The Multiplication of two numbers "+Divison(value1,value2)); 
                    
                 }break;
           }    
             Console.WriteLine("Enter your choice:");
             condition=Console.ReadLine();
        
        }while(condition=="yes");
       
       
       static int Addition(int number1,int number2) 
       {
       int sum=number1+number2;
       return sum;
       }
       static int Subtraction(int number1,int number2) 
       {
       int subtraction=number1-number2;
       return subtraction;
       }
       static int Multiplication(int number1,int number2) 
       {
       int Multiplication=number1*number2;
       return Multiplication;
       }
       static int Divison(int number1,int number2) 
       {
       int Division=number1/number2;
       return Division;
       }
    }

}

