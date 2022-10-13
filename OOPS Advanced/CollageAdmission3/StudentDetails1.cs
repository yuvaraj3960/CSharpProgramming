using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission3
{
    public  enum Gender{Default,Male,Female,Transgender}
    
    public class StudentDetails1
    {
        private static int  s_studentId=3000;
        public  string StudentName{get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender{get; set;}

        public double Physics{get; set;}
        public double Chemistry{get; set;}
        public double Maths{get; set;}
        public string StudentId{get; set;}

      /*public StudentDetails1()
        {
            StudentId="SF3001";
            StudentName="Ravichandran";
            FatherName="Ettaparajan";
            DateTime DOB= new DateTime(11/11/1999);
           Gender =Gender.Male;
           Physics=95;
           Chemistry=95;
           Maths=95;
        }*/
       


        public StudentDetails1(string name,string fatherName,DateTime dob,Gender gender,double physics,double chemistry,double maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;

            StudentName=name;
            FatherName=FatherName;
            DOB=dob;
            Gender=gender;
            Chemistry=chemistry;
            Physics=physics;
            Maths=maths;
        }

        public StudentDetails1(string data)
        {
            string[] values=data.Split(',');
            s_studentId=int.Parse(values[0].Remove(0,2));
            StudentId=values[0];

            StudentName=values[1];
            FatherName=values[2];
            DOB= DateTime.Parse(values[3]);
            Gender=Enum.Parse<Gender>(values[4]);
            Chemistry=int.Parse(values[5]);
            Physics=int.Parse(values[6]);
            Maths=int.Parse(values[7]);
        }
        public bool CheckEligibility(double cutOff)
        {
            double sum=(double) (Physics+Chemistry+Maths); 
            double average=sum/3.0;

            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Your Name is:"+StudentName);
        Console.WriteLine("Your FatherName is:"+FatherName);
        Console.WriteLine("Your DOB is:"+DOB);
        Console.WriteLine("Your Gender is:"+Gender);
        
        Console.WriteLine("Your Physics mark is:"+Physics);
        Console.WriteLine("Your Chemistry is:"+Chemistry);
        Console.WriteLine("Your Maths mark is:"+Maths);
        Console.WriteLine("Your StudentId is:"+StudentId);
        }




     
    
    }
}