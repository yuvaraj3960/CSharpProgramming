using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class ScreeningDetails
    {
        public string MovieId{get;set;}
        public string TheatreId { get; set; }

        public int NoOfSeatAvailable { get; set; }
        public double TicketPrice { get; set; }

        public ScreeningDetails(string movieId,string theartreId,int noOfSeatAvailable,double ticketPrice)
        {
            MovieId=movieId;
            TheatreId=theartreId;
            NoOfSeatAvailable=noOfSeatAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string[] values=data.Split(",");
            MovieId=values[0];
            TheatreId=values[1];
            NoOfSeatAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}