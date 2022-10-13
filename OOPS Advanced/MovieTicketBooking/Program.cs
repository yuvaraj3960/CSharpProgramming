using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MovieTicketBooking
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Files.Create();
            Files.ReadAllFiles();
            Operation.MainMenu();
            Files.WriteToFiles();

        }
        
    }
    
}