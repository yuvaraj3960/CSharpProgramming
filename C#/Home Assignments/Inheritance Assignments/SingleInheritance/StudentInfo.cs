using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentInfo:PersonnelDetail
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber{get;set;}
        public string Standard{get;set;}
        public string Branch{get;set;}
        public string AcademicYear{get;set;}

        public StudentInfo(string name,string fatherName,long phoneNumber,string mailId,DateTime dob,Gender gender,string standard,string branch,string academicYear):base( name, fatherName, phoneNumber, mailId,dob, gender)
        {
            s_registerNumber++;
            RegisterNumber="SID"+s_registerNumber;
            

            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }


        public void UpdateInfo()
        {
            string condition;
            Console.WriteLine("Enter Your Register Number");
            string id=Console.ReadLine();
            do{

            
            Console.WriteLine("1.PhoneNumber 2.MailId 3.Standard");
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
                    Console.WriteLine("Enter the Standard");
                    string standard=Console.ReadLine();
                    Standard=standard;
                    break;
                }
             }

             Console.WriteLine("Do Want to upadte");
             condition=Console.ReadLine().ToLower();
            }while(condition=="yes");
             ShowStudentInfo();


        }

        
        public void ShowStudentInfo()
        {
            Console.WriteLine("Register Number "+RegisterNumber);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your father Name "+FatherName);
            Console.WriteLine("PhoneNumber "+PhoneNumber);
            Console.WriteLine("MailId "+MailId);
            Console.WriteLine("DOB "+DOB);
            Console.WriteLine("Gender "+Gender);
            Console.WriteLine("Standard "+Standard);
            Console.WriteLine("Branch "+Branch);
            Console.WriteLine("Academic Year "+AcademicYear);
        }


    }
}