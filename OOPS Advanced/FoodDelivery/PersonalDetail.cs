using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetail
    {
             private static int  s_studentId=3000;
        public  string CustomerName{get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender{get; set;}

        public long Mobile { get; set; }
        public string MailId{get;set;}
        public string Location{get;set;}

        

       
        public string StudentId{get; set;}

        public PersonalDetail(string name,string fname,Gender gender,long mobile , DateTime dob,string mailId,string location )
        {
            CustomerName=name;
            FatherName=fname;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailId=mailId;
            Location=location;
        }

        

    }
}