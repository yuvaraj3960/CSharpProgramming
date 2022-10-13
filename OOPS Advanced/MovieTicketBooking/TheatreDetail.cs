using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class TheatreDetail
    {
        private static int s_theatreId=301;
        public string TheatreId{get;}
        public string TheatreName{get;set;}
        public string TheatreLocation{get;set;}

        public TheatreDetail(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;

        }
        public TheatreDetail(string data)
        {
            string[] values=data.Split(",");
            s_theatreId=int.Parse(values[0].Remove(0,3));
            TheatreId=values[0];
            TheatreName=values[1];
            TheatreLocation=values[2];

        }
        
    }
}