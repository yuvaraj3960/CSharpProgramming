using System;
using System.Collections.Generic;
using BankingLibrary;
namespace BankApplication;
class Operation{
    public static void MainMenu()
    {
        string addAccount="";
        List<AccountDetails> accountDetails= new List<AccountDetails>();
        do
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
        
        
        Console.WriteLine("Add account");
        addAccount=Console.ReadLine().ToLower();

        }while(addAccount=="yes");

        foreach(AccountDetails account in accountDetails)
        {
            Console.WriteLine("Your Name :"+account.Name);
            Console.WriteLine("Your FatherName :"+account.FatherName);
            Console.WriteLine("Your Gender :"+account.Gender);
            Console.WriteLine("Your DOB :"+account.DOB);
            Console.WriteLine("Your AccountType :"+account.AccountType);
            Console.WriteLine("Your Balance :"+account.Balance);
            Console.WriteLine("Your AccountNumber:"+account.AccountNumber);
            account.Deposit();
            account.WithDraw();
            account.ShowBalance();
        }
        


    }
}
