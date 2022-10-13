using System;
namespace Salary;
class Program{
    public static void Main(string[] args)
    {
        double salary1;
        Console.WriteLine("Enter the salary:");
        double salary=int.Parse(Console.ReadLine());

        if(salary<=10000)
        {
            double HRA=20/salary*100;
            double PA=80/salary*100;
            salary1=salary+HRA+PA;
            Console.WriteLine("Salary "+salary1);
            double annual=salary1*12;
            double tax=6/annual*100;
            double Insurance=1/annual*100;
            double annual1=annual-tax-Insurance;
            Console.WriteLine("Annual income "+annual1);
        }
        
        
        
        else if(salary<=20000)
        {
            double HRA=25/salary*100;
            double PA=90/salary*100;
            salary1=salary+HRA+PA;
            Console.WriteLine("Salary "+salary1);
            double annual=salary1*12;
            double tax=6/annual*100;
            double Insurance=1/annual*100;
            double annual1=annual-tax-Insurance;
            Console.WriteLine("Annual income "+annual1);
        }
        else{
            double HRA=30/salary*100;
            double PA=95/salary*100;
            salary1=salary+HRA+PA;
            Console.WriteLine("Salary "+salary1);
            double annual=salary1*12;
            double tax=6/annual*100;
            double Insurance=1/annual*100;
            double annual1=annual-tax-Insurance;
            Console.WriteLine("Annual income "+annual1);

        }

        
        
    }
    }

