using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{

    public class TeacherInfo:PersonnelInfo
    {
        private static int s_teacherId=1000;
        public string TeacherId{get;}
        public Department Department{get;set;}
        public string SubjectTeaching{get;set;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public DateTime DateOfJoining{get;set;}

        public TeacherInfo(string name,string fatherName,long phoneNumber,string mailId,DateTime dob,Gender gender,Department department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base( name,fatherName,phoneNumber, mailId, dob, gender)
        {
            s_teacherId++;
            TeacherId="TID"+s_teacherId;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowTeacherInfo()
        {
            
            Console.WriteLine("Register Number "+TeacherId);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your father Name "+FatherName);
            Console.WriteLine("PhoneNumber "+PhoneNumber);
            Console.WriteLine("MailId "+MailId);
            Console.WriteLine("DOB "+DOB);
            Console.WriteLine("Gender "+Gender);
            Console.WriteLine("Subject Teaching "+SubjectTeaching);
            Console.WriteLine("Department"+Department);
            Console.WriteLine("Qualification  "+Qualification);
            Console.WriteLine("Year Of Experience "+YearOfExperience);
            Console.WriteLine("Date of joining "+DateOfJoining);
        }

        public void UpdateTeacherInfo()
        {
            string condition;
            Console.WriteLine("Enter Your Register Number");
            string id=Console.ReadLine();
            do{

            
            Console.WriteLine("1.PhoneNumber 2.MailId 3.Subject Teaching 4.YearofExperience");
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
                    Console.WriteLine("Enter the subject teaching");
                    string subjectTeaching=Console.ReadLine();
                    SubjectTeaching=subjectTeaching;
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Enter the YearOfExperience");
                    int yearOfExperience=int.Parse(Console.ReadLine());
                    YearOfExperience=yearOfExperience;

                    break;
                }
             }

             Console.WriteLine("Do Want to upadte");
             condition=Console.ReadLine().ToLower();
            }while(condition=="yes");
             ShowTeacherInfo();


        }

    }
}