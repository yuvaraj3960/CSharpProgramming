using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetail
    {
        private static int s_orderId=2000;
        public string UserId{get;}
        public string MedicineId{get;}

        public int MedicineCount{get;set;}
        public double TotalPrice{get;set;}
        public DateTime OrderDate{get;set;}
        public OrderStatus OrderStatus{get;set;}
        public string OrderId{get;set;}

        public OrderDetail(string userId,string MedicineId,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
            


        }
        public OrderDetail(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            UserId=values[1];
    
           MedicineId=values[2];
           MedicineCount=int.Parse(values[3]);
           TotalPrice=double.Parse(values[4]);
           OrderDate=DateTime.Parse(values[5]);
           OrderStatus=Enum.Parse<OrderStatus>(values[6]);

            
        }
        

    }
}