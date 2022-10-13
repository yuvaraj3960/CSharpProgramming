using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:Irectangle
    {
        public double Area { get; set; }

        public double Length{get;set;}
        public double Breadth{get;set;}

        public void GetData(double length,double breadth)
        {
            Length=length;
            Breadth=breadth;

        }

        public void CalculateArea()
        {
             
             Area=Length*Breadth;
             Console.WriteLine(Area);
            
        }
        
    }
}