using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class CustomerDetails:PersonnelDetails
    {
        private static int s_customerId=1000;
        public string CustomerId{get;set;}
        public double Balance{get;set;}

        public CustomerDetails(string aadharId,string name,string fatherName,Gender gender,long phoneNumber):base(name,fatherName,gender,phoneNumber)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;

        }
        public void  Recharge()
        {
            Console.WriteLine("Enter the amount to recharge");
            Balance+=double.Parse(Console.ReadLine());

        }
        public void showCustomer()
        {
            Console.WriteLine("CustomerID "+CustomerId);
            showDetails();
            Recharge();
            Console.WriteLine("Balance "+Balance);
            
        }
    }
}