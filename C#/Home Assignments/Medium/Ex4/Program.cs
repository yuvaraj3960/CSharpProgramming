using System;
namespace Armstrong;
class Program{
    public static void Main(string[] args)
    {
        int i=1,digit=0;
        Console.WriteLine("Enter the lower limit:");
        int lower_limit=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the upper_limit:");
        int upper_limit=int.Parse(Console.ReadLine());

        while(lower_limit<=upper_limit)
        {
            i=i%10;
            digit=digit*10+i*i*i;
            i/=10;
            lower_limit++;
    
        }   
    
        
        if(digit==lower_limit)
        {
            Console.WriteLine("Armstrong number:");
        }
        else
        {
            Console.WriteLine("not an Armstrong number");
        }
        }
    }

