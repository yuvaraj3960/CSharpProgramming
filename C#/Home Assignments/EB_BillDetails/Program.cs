using System;
using System.Collections.Generic;
namespace EB_BillDetails;
class Program{
    public static void Main(string[] args)
    {
        List<EB_Bill> ebList= new List<EB_Bill>();
        string generate="";
        do{
        Console.WriteLine("Enter your UserName :");
        string name=Console.ReadLine();

        Console.WriteLine("Enter Your PhoneNumber:");
        long phone=long.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your MailId:");
        string mail=Console.ReadLine();

        Console.WriteLine("Enter the units consumed:");
        double units=double.Parse(Console.ReadLine());

        EB_Bill eb= new EB_Bill(name,phone,mail,units);
        ebList.Add(eb);

        Console.WriteLine("Generate Bill");
        generate=Console.ReadLine();
        }while(generate=="yes");



    
    foreach (EB_Bill ebBill in ebList)
    {
        Console.WriteLine("MeterId: "+ebBill.MeterId);
        Console.WriteLine("UserNAme: "+ebBill.UserName);
        Console.WriteLine("PhoneNumber: "+ebBill.PhoneNumber);
        Console.WriteLine("MailId: "+ebBill.MailId);
        ebBill.CalculateEbBill();
        
    }
     }
}
