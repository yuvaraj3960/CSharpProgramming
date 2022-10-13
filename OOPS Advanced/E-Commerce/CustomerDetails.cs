using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce
{

    public class CustomerDetails
    {
        private static int s_customerId=1000;

        public string CustomerName{get; set;}

        public string City{get; set;}
        public long PhoneNumber{get; set;}
        public String MailId{get;set;}
        public Double InitialBalance{get;set;}
        public string CustomerId{get;}

        public CustomerDetails(string customerName,string city,long phoneNumber,String mailId,double initialBalance)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            CustomerName=customerName;
            City=city;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            InitialBalance=initialBalance;
        }

        
        public CustomerDetails(string data)
        {
            string[] values=data.Split(",");
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            CustomerName=values[1];
            City=values[2];
            PhoneNumber=long.Parse(values[3]);
            MailId=values[4];
            InitialBalance=double.Parse(values[5]);
        }
        
        
    }
}