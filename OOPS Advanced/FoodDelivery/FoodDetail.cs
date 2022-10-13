using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class FoodDetail
    {
        private static int s_foodId=100;
        public string FoodId{get;set;}
        public string FoodName{get;set;}
        public double FoodPrice{get;set;}

        public FoodDetail(string foodName,double foodPrice)
        {
            s_foodId++;
            FoodId="FID"+s_foodId;
            FoodName=foodName;
            FoodPrice=foodPrice;
        }
    }
}