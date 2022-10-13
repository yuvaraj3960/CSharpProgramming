using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IfamilyInfo:IshowData
    {
         string  FatherName { get; set; }
         string  MotherName{get;set;}
         string Address{get;set;}
         int NoOfSiblings{get;set;}

         void ShowInfo(); 
    }
}