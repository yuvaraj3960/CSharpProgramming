using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public enum BookingStatus{Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=7000;
        public string BookingId { get;  }

        public string UserId{get;set;}
        public string TheatreId{get;set;}
        public string MovieId{get;set;}
        public int SeatCount{get;set;}
        public double TotalAmount{get;set;}
        public BookingStatus BookingStatus1{get;set;}

        public BookingDetails(string userId,string movieId,string theartreId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theartreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus1=bookingStatus;

        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            UserId=values[1];
            MovieId=values[2];
            TheatreId=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus1=Enum.Parse<BookingStatus>(values[6]);

      
        }
        public void BookingDetail()
        {
        System.Console.WriteLine("Booking Id "+BookingId);
        System.Console.WriteLine("User ID "+ UserId);
        System.Console.WriteLine("MovieId "+ MovieId);
        System.Console.WriteLine("TheatreId "+TheatreId);
        System.Console.WriteLine("SeatCount "+SeatCount);
        System.Console.WriteLine("TotalAmount "+TotalAmount);
        System.Console.WriteLine("BookingStatus "+BookingStatus1);
        }
     


    }
}