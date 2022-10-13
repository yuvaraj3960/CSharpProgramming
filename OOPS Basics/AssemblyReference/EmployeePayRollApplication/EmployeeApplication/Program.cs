using System;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeeApplication;
class Program{
    
    public static void Main(string[] args)
    {
        List<EmployeePayRollDetails> employeeList=new List<EmployeePayRollDetails>();
        string condition="";
         do
         {
        Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();

        Console.WriteLine("Enter Your Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        Console.WriteLine("Enter Your Role:");
        string role=Console.ReadLine();

        Console.WriteLine("Enter Your Work location:");
             WorkLocation location=Enum.Parse<WorkLocation>(Console.ReadLine(),true);

        Console.WriteLine("Enter Your Team name:");
        string teamName=Console.ReadLine();

        Console.WriteLine("Enter Your Date of joining:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter the number of Total working days:");
        int workingDays=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of leave taken:");
        int leaveTaken=int.Parse(Console.ReadLine());

       

        EmployeePayRollDetails employee1=new EmployeePayRollDetails(name,gender,role,location,teamName,dob,workingDays,leaveTaken);
        employeeList.Add(employee1);

         Console.WriteLine("Enter Your Details:");
        condition=Console.ReadLine().ToLower();
        

        }while(condition=="yes");

        foreach(EmployeePayRollDetails Emproll in employeeList)
        {
            Console.WriteLine("EmployeeNAme "+Emproll.EmployeeName);
        
        
          Console.WriteLine("Gender "+Emproll.Gender); 
            Console.WriteLine("EmployeeRpoll "+Emproll.EmployeeRoll);
              Console.WriteLine("Employee Work Location "+Emproll.EmployeeWorkLocation);
                Console.WriteLine("Employee Team Name "+Emproll.TeamName);
                  Console.WriteLine("DateOfJoining "+Emproll.DateOfJoining);
                  Emproll.CalculateSalary();
        }








    }
}
