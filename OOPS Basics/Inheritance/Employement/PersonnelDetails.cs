using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employement
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonnelDetails
    {
        private static int s_aadharId=1000;
        public string AadharId{get;}

        public string Name{get; set;}

        public string FatherName  { get; set; }

        public  Gender Gender{get; set;}
        public long PhoneNumber{get; set;}

        public PersonnelDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_aadharId++;
            AadharId="AID"+s_aadharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }

        public void showDetails()
        {
            Console.WriteLine("Your Id"+ AadharId);
            Console.WriteLine("Your name is "+Name);
            Console.WriteLine("Your Father Name is "+FatherName);
            Console.WriteLine("Your Gender "+Gender);
            Console.WriteLine("Your PhoneNumber "+PhoneNumber);
        }


    }
}