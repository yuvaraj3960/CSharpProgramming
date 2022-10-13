using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce
{
    

    public class ProductDetails
    {
        private static int  s_productId=100;
        public string ProductName{get; set;}
        public int AvalaibleStock {get;set;}
        public double Price{get;set;}
        public int ShippingDuration{get;set;}
        public string ProductId{get;set;}

        public ProductDetails(string productName,int avalaibleStock,double price,int shippingDuration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            AvalaibleStock=avalaibleStock;
            Price=price;
            ShippingDuration=shippingDuration;


        }

        public ProductDetails(string data)
        {
            string[] values=data.Split(",");
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductId=values[1];
            ProductName=values[2];
            AvalaibleStock=int.Parse(values[3]);
            Price=double.Parse(values[4]);
            ShippingDuration=int.Parse(values[5]);
        }

    }
}