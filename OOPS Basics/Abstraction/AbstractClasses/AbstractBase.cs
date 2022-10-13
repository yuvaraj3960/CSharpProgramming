using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        protected string name;//Normal Field
        public abstract string Name{get;set;}//Abstract property
        public double Amount{get;set;}//Normal Property
        public void Display(){Console.WriteLine(name);}//Normal Method
        public abstract void Salary(int dates);//Abstract Method
        
    }
}