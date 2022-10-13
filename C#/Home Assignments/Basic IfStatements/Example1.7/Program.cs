using System;
namespace EbBill;
class Program
{
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.WriteLine("Enter the customer_id");
            int customer_id=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the customer_name");
            string customer_name=Console.ReadLine();
              
            Console.WriteLine("Enter the units consumed");
            double units= double.Parse(Console.ReadLine());
            
            Console.WriteLine("Customer_id:"+" "+customer_id);
            Console.WriteLine("Customer_name:"+" "+customer_name); 
            Console.WriteLine("Units consumed:"+ " " +units);


            if(units<=199)
            {
                double charge=units*1.20;
                if (charge<100)
                {
                    Console.WriteLine("Amount charges @1.20 is 100");
                }
                else
                {
                Console.WriteLine("Amount charges @1.20 per unit"+" "+ charge);
                }
                
            }
            else if(units>=200 && units<400)
            {
                double charge=units*1.50;
                if (charge>400)
                {
                    double surcharge=charge*0.15;
                    Console.WriteLine("Amount charges @1.50 per unit"+" "+ charge);
                    Console.WriteLine("Surcharge Amount"+" "+ surcharge);
                    double total=charge+surcharge;
                    Console.WriteLine("Net Amount Paid by the Customer"+" "+ total);
                }
                else
                {

                Console.WriteLine("Amount charges @1.50 per unit"+" "+ charge);
                }
            }
            else if(units>=400 && units<600)
            {
                double charge=units*1.80;
                if (charge>400)
                {
                    double surcharge=charge*0.15;
                    Console.WriteLine("Amount charges @1.80 per unit"+" "+ charge);
                    Console.WriteLine("Surcharge Amount"+" "+ surcharge);
                    double total=charge+surcharge;
                    Console.WriteLine("Net Amount Paid by the Customer"+" "+ total);
                }
                else
                {
                    Console.WriteLine("Amount charges @1.80 per unit"+" "+ charge);

                }
            
            }
            else if(units>=600)
            {
                double charge=(double)units*2.00;
                double surcharge=(double) charge*0.15;
                Console.WriteLine("Amount charges @2.00 per unit"+" "+ charge);
                Console.WriteLine("Surcharge Amount"+" "+ surcharge);
                double total=(double) charge+surcharge;
                Console.WriteLine("Net Amount Paid by the Customer"+" "+ total);
            }
               }       }
            
  
    



