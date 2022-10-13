using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class operation
    {
         static EmployeePayRollDetails currentEmployee=null;
       static List<EmployeePayRollDetails> employeeList=new List<EmployeePayRollDetails>();
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
            Console.WriteLine("Select Option 1.Registration,2.Login,3.Exit");
            int option=int.Parse(Console.ReadLine());
            
            
              switch(option)
              {
                case 1:
                {
                    Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
              }
            }while(choice=="yes");
        }

        public static void Registration()
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

       /* Console.WriteLine("Enter the number of Total working days:");
        int workingDays=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of leave taken:");
        int leaveTaken=int.Parse(Console.ReadLine());*/

       

        EmployeePayRollDetails employee1=new EmployeePayRollDetails(name,gender,role,location,teamName,dob);
        employeeList.Add(employee1);
        Console.WriteLine("Your EmployeeID is:"+employee1.EmployeeId);

        }

        public static void Login()
        {
           
        
            Console.WriteLine("Enter Your EmployeeID:");
            string id=Console.ReadLine().ToUpper();
            foreach(EmployeePayRollDetails student in employeeList)
            {
                if(student.EmployeeId==id)
                {
                    Console.WriteLine("login successfull");
                    currentEmployee=student;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
             string choice2="yes";
            do{
            Console.WriteLine("1.ShowDetails 2.Get Number of leave  3.Calculate Salary 4.Exit submenu");
            int option1=int.Parse(Console.ReadLine());

            switch(option1)
            {
                case 1:
                {
                    Console.WriteLine("Show Details ");
                    currentEmployee.ShowDetails();
                    
                    break;
                }
                case 2:
                {
                     
                    
                    
                    Console.WriteLine("Enter the number of Total working days:");
                    int workingDays=int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of leave taken:");
                    int leaveTaken=int.Parse(Console.ReadLine());
                    

                    break;
                }
                case 3:
                {
                    Console.WriteLine("Calculate Salary");
                    currentEmployee.CalculateSalary();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Exit submenu");
                    choice2="no";
                    break;
                }
            }
        }while(choice2=="yes");
        
    }
}
}