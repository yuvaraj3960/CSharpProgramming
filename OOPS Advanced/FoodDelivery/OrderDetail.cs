using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class OrderDetail
    {
        private static int s_orderId=100;
        public string OrderId{get;}
        public string BookingId{get;set;}

        public string FoodId{get;set;}

        public int PurchaseCount{get;set;}
        public double PriceOfOrder{get;set;}

        public OrderDetail(string bookingId,string foodId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        

    }
}