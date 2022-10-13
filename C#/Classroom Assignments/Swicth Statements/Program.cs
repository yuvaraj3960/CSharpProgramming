using System;
namespace SwitchStatement;
   class Progrm{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1");
        int number1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the number2");
        int number2=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the Choice 1.+,2.-,3.*,4./,5.%");
        char Choice=Convert.ToChar(Console.ReadLine());
        
        switch(Choice)
        {
            case '+':
                        {
                            int sum=number1+number2;
                        Console.WriteLine("Result"+" "+sum );
                        break;
                        }
             case '-':
                        {
                            int subtraction=number1-number2;
                        Console.WriteLine("Result"+" "+subtraction );
                        break;
                        }
             case '*':
                        {
                            int multiplication=number1*number2;
                        Console.WriteLine("Result"+" "+multiplication );
                        break;
                        }
             case '/':
                        {
                            int division=number1/number2;
                            Console.WriteLine("Result"+" "+division);
                        break;

                        }
             case '%':
                        {
                            int modulo=number1%number2;
                            Console.WriteLine("Result"+" "+modulo);
                            break;
                        }
             default:
                        {
                            Console.WriteLine("Operation Invalid");
                            break;
                        }
        
        

            }
        }


        
        
        
    }

