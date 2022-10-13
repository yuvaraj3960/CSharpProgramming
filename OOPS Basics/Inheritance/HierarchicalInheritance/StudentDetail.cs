using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public enum Department{Default,CSE,EEE,ECE}
    public class StudentDetails1:PersonnelDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get;  }
        public Department Department{get; set;}

        public string Year{get;set;}

        public StudentDetails1(string aadharId,string name,string fatherName,Gender gender,long phoneNumber,Department department,String year):base(aadharId,name,fatherName,gender,phoneNumber)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;
        }

        public void ShowStudent()
        {
            Console.WriteLine("Student Id"+StudentId);
            showDetails();
            Console.WriteLine("Department "+Department);
            Console.WriteLine("Year"+Year);
        }
    }
}
  