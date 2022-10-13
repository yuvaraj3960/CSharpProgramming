using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("MovieTicketBooking");
            }
            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/UserDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/TheatreDetail.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/TheatreDetail.csv");
            }
            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/BookingDetails.csv");
            }
            
           
  
            
        }
        
        public static void ReadAllFiles()
        {
            string[] users=File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user=new UserDetails(data);
                Operation.userList.Add(user);
            }
            string[] theatres=File.ReadAllLines("MovieTicketBooking/TheatreDetail.csv");
            foreach(string data in theatres)
            {
                TheatreDetail theatre = new TheatreDetail(data);
                Operation.theatreList.Add(theatre);
            }
            string[] movies=File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string data in movies)
            {
                MovieDetails movie = new MovieDetails(data);
                Operation.movieList.Add(movie);
            }
            string[] screenings=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string data in screenings)
            {
                ScreeningDetails screening=new ScreeningDetails(data);
                Operation.screeningList.Add(screening);
            }
            string[] bookings=File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string data in bookings)
            {
                BookingDetails booking=new BookingDetails(data);
                Operation.bookingList.Add(booking);
            }
           
        }

        public static void WriteToFiles()
        {
            string[] users=new string[Operation.userList.Count];
            for(int i=0;i<Operation.userList.Count;i++)
            {
                users[i]=Operation.userList[i].UserId+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",users);

            string[] theatres=new string[Operation.theatreList.Count];
            for(int i=0;i<Operation.theatreList.Count;i++)
            {
                 theatres[i]=Operation.theatreList[i].TheatreId+","+Operation.theatreList[i].TheatreName+","+Operation.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetail.csv",theatres);

             string[] movies=new string[Operation.movieList.Count];
            for(int i=0;i<Operation.movieList.Count;i++)
            {
                 movies[i]=Operation.movieList[i].MovieId+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].MovieLanguage;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movies);

            string[] screenings=new string[Operation.screeningList.Count];
            for(int i=0;i<Operation.screeningList.Count;i++)
            {
                 screenings[i]=Operation.screeningList[i].MovieId+","+Operation.screeningList[i].TheatreId+","+Operation.screeningList[i].NoOfSeatAvailable+","+Operation.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screenings);

            string[] bookings=new string[Operation.bookingList.Count];
            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                 bookings[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].UserId+","+Operation.bookingList[i].MovieId+","+Operation.bookingList[i].TheatreId+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatus1;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookings);
        
        }
    }
}