using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetail
    {
        private static int s_bookingId=3000;
        public string BookingId{get;}

        public string CustomerId{get;set;}

        public double TotalPrice{get;set;}
        public DateTime DateOfBooking{get;set;}

        public BookingStatus BookingStatus1{get;set;}

        public BookingDetail(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus status)
    {
        s_bookingId++;
        BookingId="BID"+s_bookingId;
     
        TotalPrice=totalPrice;
        DateOfBooking=dateOfBooking;
        BookingStatus1=status;
    }

    }
}