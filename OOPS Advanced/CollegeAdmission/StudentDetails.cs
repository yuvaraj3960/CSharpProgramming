using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        //private string _name;//Field declaration
        //public string Name { get{return _name;} set{_name=value;} }

        public string Name {get; set;} //Auto property
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public string Gender {get; set;}
        public long Phone {get; set;}
        public string Mail {get; set;}
        public int Physics {get; set;}
        public int Chemistry {get; set;}
        public int Maths {get; set;}

        public StudentDetails()
        {
            Name="Your Name";
            FatherName="Your Father";
            Gender="Your Gender";
        }

        public StudentDetails(string name,string fatherName,DateTime dob,string gender,long phone,string mail,int physics,int chemistry,int maths)
        {
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Mail=mail;
            Phone=phone;
            Physics=physics;
            Chemistry=chemistry;

        }
        
        
        
    }
}