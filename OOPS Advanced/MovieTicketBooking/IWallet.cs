using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public interface IWallet
    {
        public double WalletBalance { get; set; }

        public void RechargeWallet(double WalletBalance);
        
    }
}