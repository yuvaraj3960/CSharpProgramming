using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class CustomerRegistration:PersonalDetail,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId{get;}
        public double Balance{get;set;}

        public CustomerRegistration(string name,string fname,Gender gender,long mobile , DateTime dob,string mailId,string location ):base(name, fname, gender,mobile ,  dob, mailId, location )
        {
           s_customerId++;
           CustomerId="CID"+s_customerId;
           
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge");
            double amount=double.Parse(Console.ReadLine());

            Balance+=amount;
            System.Console.WriteLine("YourBalance "+Balance);

        }
    }
}