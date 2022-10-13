using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class PersonalDetail
    {
        public string Name { get; set; }
        public int Age{get;set;}
        public long PhoneNumber{get;set;}

        public PersonalDetail(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }

        public PersonalDetail()
        {
            
        }

       

    }
}