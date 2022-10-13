using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public class OrderDetail
    {
        private static int s_orderId=100;
        public string OrderId { get; }
        public string BookingId{get;set;}
        public string  ProductId { get;set; }
        public int  PurchaseCount { get;set; }

        public double PriceOfOrder{get;set;}

        public OrderDetail(string bookingId,string productId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetail(string data)
        {
            string[] values=data.Split(",");
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[1];
            BookingId=values[2];
            ProductId=values[3];
            PurchaseCount=int.Parse(values[4]);
            PriceOfOrder=double.Parse(values[5]);

        }

        public void ShowOrderDetails()
        {
            System.Console.WriteLine("OrderID "+OrderId);
            System.Console.WriteLine("BookingId "+BookingId);
            System.Console.WriteLine("ProductID "+ProductId);
            System.Console.WriteLine("Purchase "+PurchaseCount);
            System.Console.WriteLine("Price of Order "+PriceOfOrder);
        }
        

        
    
    }
}