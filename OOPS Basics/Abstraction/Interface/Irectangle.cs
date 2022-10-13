using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface Irectangle
    {
        double Length{get;set;}
        double Breadth{get;set;}

        void CalculateArea();
        void GetData(double Length,double Breadth);

        
    }
}