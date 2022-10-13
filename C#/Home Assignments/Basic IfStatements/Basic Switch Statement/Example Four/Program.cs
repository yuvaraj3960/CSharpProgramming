using System;
namespace Operation;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the First number:");
        int firstnumber=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second number:");
        int secondnumber=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your choice:");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
            int sum=firstnumber+secondnumber;
            Console.WriteLine("Addition of Two numbers is"+" "+sum);
            break;
            }
        
        
            case 2:
            {
            int subtraction=firstnumber-secondnumber;
            Console.WriteLine("Subtraction of Two numbers is"+" "+subtraction);
            break;
            }
        
               
            case 3:
            {
            int multiplication=firstnumber*secondnumber;
            Console.WriteLine("Multipliction of Two numbers is"+" "+multiplication);
            break;
            }
               
            case 4:
            {
            int division=firstnumber/secondnumber;
            Console.WriteLine("Division of Two numbers is"+" "+division);
            break;
            }

            default:
            {
            Console.WriteLine("Invalid Input");
            break;
            }
        }
    }
}
