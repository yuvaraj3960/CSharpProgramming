using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string Name {get; set;}

        public static int RegisterNumber ;

        static  StudentInfo()
        {
            Name="yuvaraj";
            RegisterNumber=3960;
            
        }

        public static void Display()
        {
            Console.WriteLine("RegisterNumber"+RegisterNumber);
            Console.WriteLine("Name"+Name);
        }
    }
}