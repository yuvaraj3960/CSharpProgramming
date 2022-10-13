using System;
namespace Salary;
class Program{
    public static void Main(string[] args)
    {
        int salary=500; 
        Console.WriteLine("Enter the month");
        string month=Console.ReadLine();

        Console.WriteLine("Enter the number of leave taken ");
        int leave=int.Parse(Console.ReadLine().ToLower());

        switch(month)
        {
            case "jan":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;

            }
            case "feb":
            {
                int salary1=28*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            }
             case "march":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            }
             case "april":
            {
                int salary1=30*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            }
             case "may":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            }
             case "june":
            {
                int salary1=30*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "july":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "august":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "september":
            {
                int salary1=30*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "october":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "november":
            {
                int salary1=30*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            } case "december":
            {
                int salary1=31*salary-leave*salary;
                Console.WriteLine("salary "+salary1);
                break;
            }
            
        }
        }
    }

