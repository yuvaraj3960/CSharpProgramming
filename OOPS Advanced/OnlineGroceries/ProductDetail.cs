using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public class ProductDetail
    {
        private static int s_productId=100;
        public string ProductId{ get;}
        public string  ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double  PricePerQuantity { get; set; }

        public ProductDetail(string productName,int quantityAvailable,double pricePerQuantity)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }

        public ProductDetail(string data)
        {
            string[] values=data.Split(",");
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductId=values[0];
            ProductName=values[1];
            QuantityAvailable=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);

        }

        public void ShowProductDetails()
        {
           
            System.Console.WriteLine("ProductId "+ProductId);
            System.Console.WriteLine("ProductName "+ProductName);
            System.Console.WriteLine("Quantity Available"+QuantityAvailable);
            System.Console.WriteLine("Price per quantity"+PricePerQuantity);


        }
    }
}