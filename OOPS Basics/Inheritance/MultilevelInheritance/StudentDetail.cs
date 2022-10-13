using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public enum Department{Default,CSE,EEE,ECE}
    public class StudentDetails1:PersonnelDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get;  }
        public Department Department{get; set;}

        public string Year{get;set;}

        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int Total{get;set;}
        public double Average{get;set;}

        public StudentDetails1(string aadharId,string name,string fatherName,Gender gender,long phoneNumber,Department department,String year):base(aadharId,name,fatherName,gender,phoneNumber)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;
        }
         public StudentDetails1(string studentId,string aadharId,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(aadharId,name,fatherName,gender,phoneNumber)
        {
            StudentId=studentId;
           
            Department=department;
            
        }

        public void ShowStudent()
        {
            Console.WriteLine("Student Id"+StudentId);
            showDetails();
            Console.WriteLine("Department "+Department);
            Console.WriteLine("Year"+Year);
        }
        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=Total/3;
            Console.WriteLine("Average "+Average);
        }
        public void ShowDetails1()
        {
            Console.WriteLine("Physics mark"+Physics);
            Console.WriteLine("Chemistry mark "+Chemistry);
            Console.WriteLine("Maths "+Maths);
        }
    }
}

  