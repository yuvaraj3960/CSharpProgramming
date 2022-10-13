using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EB_BillDetails
{
    public class EB_Bill
    {
        public static int s_meterId=1000;

        public string MeterId{get;}
        public string  UserName{get;set;}

        public long PhoneNumber{get; set;}

        public string MailId{get; set;}

        public double Units{get; set;}

        public EB_Bill(string name,long phone,string mail,double units)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=name;
            PhoneNumber=phone;
            MailId=mail;
            Units=units;
        }
        public void CalculateEbBill()
        {
            if(Units<=100)
            {
                Console.WriteLine("Zero charges");
                
            }
            else if(Units>100 && Units<=200)
            {
                double bill=Units-100*0+Units-100*3;
                Console.WriteLine("Amount : "+bill);
            }
            else if(Units>200 && Units<=400)
            {
                double bill=Units*5;
                Console.WriteLine("Amount : "+bill);

            }
            
            else if(Units>400)
            {
                double bill=Units*6;
                Console.WriteLine("Amount : "+bill);
            }
        }


    }
}