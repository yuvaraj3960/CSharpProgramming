using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonnelDetail
    {
        public string Name { get; set; }
        public string FatherName{get;set;}
        public long PhoneNumber{get;set;}
        public string MailId{get;set;}

        public DateTime DOB{get;set;}
        public Gender Gender{get;set;}

        public PersonnelDetail(string name,string fatherName,long phoneNumber,string mailId,DateTime dob,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            DOB=dob;
            Gender=gender;
        }




    }
}