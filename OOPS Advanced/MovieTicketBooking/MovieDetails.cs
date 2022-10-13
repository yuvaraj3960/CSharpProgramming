using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class MovieDetails
    {
        private static int s_movieId=1000;
        public String MovieId{get;}
        public string MovieName{get;set;}

        public string MovieLanguage{get;set;}

        public MovieDetails(string movieName,string movieLanguage)
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            MovieLanguage=movieLanguage;
        }
        public MovieDetails(string data)
        {
            string[] values=data.Split(",");
            s_movieId=int.Parse(values[0].Remove(0,3));
            MovieId=values[0];
            MovieName=values[1];
            MovieLanguage=values[2];
        }
    }
}