using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=1000;
        public string CustomerId{get;}
        public string ProductId{get;}
        public double TotalPrice{get;set;}
        public DateTime PurchaseDate{get;set;}
        public int QuantityPurchased{get;set;}
        public OrderStatus OrderStatus{get;set;}
        public string OrderId{get;}

        public OrderDetails(string customerId,string productId,double price,DateTime purchaseDate,int quantityPurchased,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=price;
            PurchaseDate=purchaseDate;
            QuantityPurchased=quantityPurchased;
            OrderStatus=orderStatus;


        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(",");
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            CustomerId=values[1];
            ProductId=values[2];
            TotalPrice=double.Parse(values[3]);
            PurchaseDate=DateTime.Parse(values[4]);
            QuantityPurchased=int.Parse(values[5]);
            OrderStatus=Enum.Parse<OrderStatus>(values[6]);
        }
        
    }
}