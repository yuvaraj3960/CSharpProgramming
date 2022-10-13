using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission3
{
    public enum Department{Default,EEE,MECH,CSE,ECE}
    public class DepartmentDetails
    {
        private static int s_DepartmentId=101;

        public string DepartmentId{get; set;}
        

        public string DepartmentName{get; set;}

        public int NumberOfSeats{get; set;}


        public DepartmentDetails(String name,int numberOfSeats)
        {
            DepartmentId="DID"+s_DepartmentId++;
            DepartmentName=name;
            NumberOfSeats=numberOfSeats;



        

        }

          public DepartmentDetails(String data)
        {
            string[] values=data.Split(',');
            s_DepartmentId=int.Parse(values[0].Remove(0,2));
            DepartmentId=values[0];
            DepartmentName=values[1];
            NumberOfSeats=int.Parse(values[3]);



        

        }
        
        

        



        
    }
}