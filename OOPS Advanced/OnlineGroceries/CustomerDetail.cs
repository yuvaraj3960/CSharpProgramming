using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public class CustomerDetail:PersonnelDetail,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get; }
        public double WalletBalance { get; set; }

        public CustomerDetail(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailId):base( name, fatherName, gender, mobile, dob, mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            
        }

        public CustomerDetail(string data)
        {
            string[] values=data.Split(",");
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender1=Enum.Parse<Gender>(values[3]);
            Mobile=long.Parse(values[4]);
            DOB=DateTime.Parse(values[5]);
            MailId=values[6];


        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount");
            double amt=double.Parse(Console.ReadLine());

            WalletBalance+=amt;

            System.Console.WriteLine("Your Balance "+WalletBalance);

        }

        public void ShowCustomerDetails()
        {

            System.Console.WriteLine("CustomerId"+CustomerId);
            System.Console.WriteLine("Name"+Name);
            System.Console.WriteLine("FatherName"+FatherName);
            System.Console.WriteLine("Gender"+Gender1);
            System.Console.WriteLine("Mobile "+Mobile);
            System.Console.WriteLine("DOB "+DOB);
            System.Console.WriteLine("MailId "+MailId);
            

            
        
        }
    }
}