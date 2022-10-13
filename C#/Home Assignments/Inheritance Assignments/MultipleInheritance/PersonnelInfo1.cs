using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum MaritalStatus{Default,Single,Married}
    
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonnelInfo1:IshowData
    {
        public string Name { get; set; }
        
        public long PhoneNumber{get;set;}
        public long Mobile{get;set;}

        public DateTime DOB{get;set;}
        public Gender Gender{get;set;}
        public MaritalStatus MaritalStatus{ get; set; }

        public PersonnelInfo1(string name,long phoneNumber,long mobile,DateTime dob,Gender gender,MaritalStatus maritalStatus)
        {
            Name=name;
          
            PhoneNumber=phoneNumber;
            Mobile=mobile;
            DOB=dob;
            Gender=gender;
            MaritalStatus=maritalStatus;
        }

         public void ShowInfo()
        {
            
            Console.WriteLine("Your Name "+Name);
            
            Console.WriteLine("PhoneNumber "+PhoneNumber);
            Console.WriteLine("Mobile  "+Mobile);
            Console.WriteLine("DOB "+DOB);
            Console.WriteLine("Gender "+Gender);
            Console.WriteLine("Marital Status"+MaritalStatus);
    
        }


    }
}