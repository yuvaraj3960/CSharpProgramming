using System;
using System.Collections.Generic;
//using BankingLibrary;
namespace BankAccountDetails;

class Operation{
    static AccountDetails currentAccount=null;
    static List<AccountDetails> accountDetails= new List<AccountDetails>();
    public static void MainMenu()
    {
        

        string choice="yes";
            do
            {
            Console.WriteLine("Select Option 1.Registration,2.Login,3.Exit");
            int option=int.Parse(Console.ReadLine());
            
            
              switch(option)
              {
                case 1:
                {
                    Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
              }
            }while(choice=="yes");

        }
        public static void Registration()
           {
            Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();

        Console.WriteLine("Enter Your FatherName:");
        string fatherName=Console.ReadLine();

        Console.WriteLine("Enter Your Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        Console.WriteLine("Enter Your DOB:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter your Account Type:");
        AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);

        AccountDetails account1=new AccountDetails(name,fatherName,gender,dob,accountType);
        
        accountDetails.Add(account1);
        Console.WriteLine("Your AccountNumber:"+account1.AccountNumber);
        
        
            
           }

            public static void Login()
        {
            Console.WriteLine("Enter Your Account Number:");
            string number=Console.ReadLine().ToUpper();
            foreach(AccountDetails student in accountDetails)
            {
                if(student.AccountNumber==number)
                {
                    Console.WriteLine("login successfull");
                    currentAccount=student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice1="yes";
            do{
                Console.WriteLine("Enter the submenu");
                Console.WriteLine("1.ShowDetails 2.deposit 3.withdraw 4.Show balance  5.Exit Submenu");
                int choose=int.Parse(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                    {
                        Console.WriteLine("ShowDetails");
                        currentAccount.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Deposit");
                        currentAccount.Deposit();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Withdraw");
                        currentAccount.WithDraw();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("ShowBalance");
                        currentAccount.ShowBalance();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Exit Submenu");
                        choice1="no";
                        break;
                    }
                }

            } while (choice1=="yes");       
           
  
        } 
}
