using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceries
{
    public enum BookingStatus{Default,Booked,Cancelled,Initiated}
    public class BookingDetail
    {
        private static int s_bookingId=3000;
        public string  BookingId { get;  }
        public string  CustomerId { get; set; }
        public double TotalPrice{get;set;}
        public DateTime DateOfBooking{get;set;}
        public BookingStatus BookingStatus1 { get; set; }

        public BookingDetail(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus1=bookingStatus;
        }

        public void ShowBookingDetails()
        {
           System.Console.WriteLine("BookingId "+BookingId);
           System.Console.WriteLine("CustomerId "+CustomerId);
           System.Console.WriteLine("Total Price "+TotalPrice);
           System.Console.WriteLine("Date of Booking "+DateOfBooking);
           System.Console.WriteLine("Booking Status "+BookingStatus1);
        }
    }
}