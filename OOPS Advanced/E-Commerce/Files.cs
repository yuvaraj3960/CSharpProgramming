using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("E-Commerce"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("E-Commerce");
            }
            if(!File.Exists("E-Commerce/CustomerDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("E-Commerce/CustomerDetails.csv");

            }
               if(!File.Exists("E-Commerce/ProductDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("E-Commerce/ProductDetails.csv");

            }
               if(!File.Exists("E-Commerce/OrderDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("E-Commerce/OrderDetails.csv");

            }


        }

        public static void ReadFiles()
        {
            string[] customer=File.ReadAllLines("E-Commerce/CustomerDetails.csv");

            foreach(string data in customer)
            {
                CustomerDetails customers=new CustomerDetails(data);
                Operation.customerList.Add(customers);

            }

            string[] product=File.ReadAllLines("E-Commerce/ProductDetails.csv");
            foreach(string data in product)
            {
                ProductDetails products = new ProductDetails(data);
                Operation.productList.Add(products);
                
            }
            string[] order=File.ReadAllLines("E-Commerce/OrderDetails.csv");
            foreach(string data in product)
            {
                OrderDetails orders = new OrderDetails(data);
                Operation.orderList.Add(orders);
                
            }



        }

        public static void WriteFiles()
        {
            string[] customers=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                customers[i]=Operation.customerList[i].CustomerId+','+Operation.customerList[i].CustomerName+','+Operation.customerList[i].City+','+Operation.customerList[i].PhoneNumber+','+Operation.customerList[i].MailId+','+Operation.customerList[i].InitialBalance;

            }
            File.WriteAllLines("E-Commerce/CustomerDetails.csv",customers);

            string[] products=
        }



    }
}