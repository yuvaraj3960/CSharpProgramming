using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public interface IBalance
    {
        public double  Balance { get; set; }

        public void WalletRecharge();

        
    }
}