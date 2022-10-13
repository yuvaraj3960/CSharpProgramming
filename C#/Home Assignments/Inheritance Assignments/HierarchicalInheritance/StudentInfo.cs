using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public enum Department{Default,CSE,EEE,ECE}
    public class StudentInfo:PersonnelInfo
    {
        private static int s_studentId=1000;
        public string StudentId{get;set;}
        public string Degree{get;set;}
        public Department Department{get;set;}
        public string Semester{get;set;}

        public StudentInfo(string name,string fatherName,long phoneNumber,string mailId,DateTime dob,Gender gender,string degree,Department department,string semester):base(name, fatherName,phoneNumber,mailId,dob,gender)
        {
            StudentId="SID"+s_studentId++;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Register Number "+StudentId);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your father Name "+FatherName);
            Console.WriteLine("PhoneNumber "+PhoneNumber);
            Console.WriteLine("MailId "+MailId);
            Console.WriteLine("DOB "+DOB);
            Console.WriteLine("Gender "+Gender);
            Console.WriteLine("Degree "+Degree);
            Console.WriteLine("Department"+Department);
            Console.WriteLine("Semester "+Semester);
        }

         public void UpdateInfo()
        {
            string condition;
            Console.WriteLine("Enter Your Register Number");
            string id=Console.ReadLine();
            do{

            
            Console.WriteLine("1.PhoneNumber 2.MailId 3.Semester");
            int option=int.Parse(Console.ReadLine());

             switch(option)
             {
                case 1:
                {
                    Console.WriteLine("Enter the PhoneNumber");
                    long phoneNumber=long.Parse(Console.ReadLine());
                    PhoneNumber=phoneNumber;

                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter the MailId");
                    string mailId=Console.ReadLine();
                    MailId=mailId;
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter the Semester");
                    string semester=Console.ReadLine();
                    Semester=semester;
                    break;
                }
             }

             Console.WriteLine("Do Want to upadte");
             condition=Console.ReadLine().ToLower();
            }while(condition=="yes");
             ShowStudentInfo();


        }
    }
}