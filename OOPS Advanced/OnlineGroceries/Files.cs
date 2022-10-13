using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public static class Files
    {
        public static void create()
        {
            if(!Directory.Exists("OnlineGroceries"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("OnlineGroceries");
            }
            if(!File.Exists("OnlineGroceries/CustomerDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineGroceries/CustomerDetail.csv");
            }
            if(!File.Exists("OnlineGroceries/ProductDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineGroceries/ProductDetail.csv");
            }
            if(!File.Exists("OnlineGroceries/BookingDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineGroceries/BookingDetail.csv");
            }
            if(!File.Exists("OnlineGrowceries/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineGroceries/OrderDetail.csv");
            }


          
        }

        public static void ReadFile()
        {
            string[] customers=File.ReadAllLines("OnlineGroceries/CustomerDetail");
            foreach(string data in customers)
            {
                CustomerDetail customer=new CustomerDetail(data);
                Operation.customerList.Add(customer);
            }
            string[] products=File.ReadAllLines("OnlineGroceries/ProductDetail");
            foreach(string data in customers)
            {
                ProductDetail product=new ProductDetail(data);
                Operation.productList.Add(product);
            }
            string[] orders=File.ReadAllLines("OnlineGroceries/OrderDetail.csv");
            foreach(string data in orders)
            {
                OrderDetail order=new OrderDetail(data);
                Operation.orderList.Add(order);
            }

        }

        public static void WriteToFiles()
        {
            string[] customer=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                customer[i]=Operation.customerList[i].CustomerId+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender1+","+Operation.customerList[i].DOB+","+Operation.customerList[i].Mobile+","+Operation.customerList[i].MailId;
            }
            File.WriteAllLines("OnlineGroceries/CustomerDetail.csv",customer);

            string[] product=new string[Operation.productList.Count];
            for(int i=0;i<Operation.productList.Count;i++)
            {
                product[i]=Operation.productList[i].ProductId+","+Operation.productList[i].ProductName+","+Operation.productList[i].QuantityAvailable+","+Operation.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("OnlineGroceries/ProductDetail.csv",product);

            string[] order=new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].BookingId+","+Operation.orderList[i].ProductId+","+Operation.orderList[i].PurchaseCount+","+Operation.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("OnlineGroceries/OrderDetail",order);
            
            
        }
    }
}