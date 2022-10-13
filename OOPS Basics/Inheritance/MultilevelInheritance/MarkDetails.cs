using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public interface  IMarkDetails
    {
         int Physics{get;set;} // Property Declaration only allowed
         int Chemistry{get;set;}
         int Maths{get;set;}
         int Total{get;set;}
         double Average{get;set;}

         // No constructor and object
         void GetMark(int Physics,int Chemistry,int Maths);

         void Calculate();   // Method Declaration Only allowed

         void ShowDetails1();
         
         

         
    }
}