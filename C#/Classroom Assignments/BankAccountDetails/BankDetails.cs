using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountDetails
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum AccountType{Default,SB,FD,RD}
    public class AccountDetails
    {
        private static long s_accountNumber=1000;
        public string Name {get; set;}
        public string FatherName {get; set;}
        public Gender Gender {get; set;}
         
        public DateTime DOB {get; set;}

        public AccountType AccountType {get; set;}

        public double Balance {get; set;}
        public string AccountNumber{get;}

       



        
          //  private static double s_Balance=0.00;
        

        public AccountDetails(string name,string fatherName,Gender gender,DateTime dob,AccountType accountType)
        {
            s_accountNumber++;
            AccountNumber="ACC"+s_accountNumber;

            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
            

        }

        public void Deposit()
        {
            Console.WriteLine("Enter the amount for deposit");
            double deposit=double.Parse(Console.ReadLine());

            Balance+=deposit;

            Console.WriteLine("Your Balance is "+Balance);



        }
        public void  WithDraw()
        {
            Console.WriteLine("Enter the amount to be withdraw:");
            double  withdraw=double.Parse(Console.ReadLine());

            if(withdraw<=Balance)
            {
                Balance-=withdraw;
                
            }

        }
        public void ShowBalance()
        {
            Console.WriteLine("Your Balance "+Balance);


        }

        public void ShowDetails()
        
            
        {
            Console.WriteLine("Your Name :"+Name);
            Console.WriteLine("Your FatherName :"+FatherName);
            Console.WriteLine("Your Gender :"+Gender);
            Console.WriteLine("Your DOB :"+DOB);
            Console.WriteLine("Your AccountType :"+AccountType);
            Console.WriteLine("Your Balance :"+Balance);
            Console.WriteLine("Your AccountNumber:"+AccountNumber);
            
        }
        
    } 
    }
