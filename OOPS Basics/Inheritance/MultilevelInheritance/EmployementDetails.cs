using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class EmployementDetails:StudentDetails1
    {
        private static int s_registrationId=1000;
        public string RegistrationId{get;}
        public DateTime DateOfRegistration { get; set; }

        public EmployementDetails(string studentId,string aadharId,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(studentId,aadharId, name, fatherName, gender, phoneNumber, department)
        {
            s_registrationId++;
            RegistrationId="EID"+s_registrationId;
            DateTime DateOfRegistration=DateTime.Now;
        }
        public void showEmployee()
        {
            Console.WriteLine("Employement ID is "+RegistrationId);
            ShowStudent();
            Console.WriteLine("Registration Date "+DateOfRegistration.ToString("dd/MM/yyyy"));
        }
    }
}