using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonnelDetail
    {
        public string Name{get;set;}

        public string FatherName{get;set;}
        public Gender Gender1 { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB{get;set;}
        public string MailId{get;set;}

        public PersonnelDetail(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            Gender1=gender;
            Mobile=mobile;
            DOB=dob;
            MailId=mailId;
        }

        public PersonnelDetail()
        {
            
        }

    }
}