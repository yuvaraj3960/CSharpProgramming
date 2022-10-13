using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public class UserDetail
    {
        private static int s_userId=1000;
        public string  UserName { get; set; }

        public int Age{get;set;}
        public string City {get;set;}
        public long PhoneNumber{get;set;}
        public double Balance{get;set;}
        public string UserId{get;set;}

        public UserDetail(string name,int age,string city,long phoneNumber,double balance)
        {
            s_userId++;
            UserId="MID"+s_userId;
            UserName=name;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }

        public UserDetail(string data)
        {
            string[] values=data.Split(",");
            s_userId=int.Parse(values[0].Remove(0,3));
            UserId=values[0];
            UserName=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=long.Parse(values[4]);
            Balance=double.Parse(values[5]);



        }
    }
}