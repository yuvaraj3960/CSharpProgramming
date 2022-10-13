using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum WorkLocation{Default,Eymard,Mathura}
    public class EmployeePayRollDetails
    {
        public static int s_employeeId=1000;
        public string EmployeeId{get;}
        public string EmployeeName{get; set;}

        public Gender Gender{get; set;}
        public string EmployeeRoll{get; set;}
        public WorkLocation EmployeeWorkLocation{get; set;}

        public string TeamName{get; set;}
        public DateTime DateOfJoining{get; set;}
        public int NumberOfWorkingDay{get; set;}

        public int NumberOfLeaveTaken{get; set;}

        public EmployeePayRollDetails(string name,Gender gender,string roll,WorkLocation location,string teamName,DateTime dob,int workingDays,int leaveTaken)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            EmployeeName=name;
            Gender=gender;
            EmployeeRoll=roll;
            EmployeeWorkLocation=location;
            TeamName=teamName;
            DateOfJoining=dob;
            NumberOfWorkingDay=workingDays;
            NumberOfLeaveTaken=leaveTaken;



        }
        public void CalculateSalary()
        {
            double salary=NumberOfWorkingDay*500-NumberOfLeaveTaken*500;
            Console.WriteLine("Salary :"+salary);
        }




    }
}