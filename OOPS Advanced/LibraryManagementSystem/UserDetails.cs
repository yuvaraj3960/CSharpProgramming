using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum Gender{Default,Male,Female,Transgender}

    public enum Department{Default,ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registerNumber=3000;
        public  string UserName{get;set;}
        public Gender Gender{get;set;}
        public Department Department{get;set;}
        public long MobileNumber{get;set;}
        public string MailId{get;set;}

        public string RegisterNumber{get;}

        public UserDetails(string userName,Gender gender,Department department,long mobileNumber,string mailId)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Gender=gender;;
            MobileNumber=mobileNumber;
            MailId=mailId;
        }
    }
}