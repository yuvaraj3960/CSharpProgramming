using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class ClassRegisterPerson
    {
         private static int s_registerNumber=1000;
         public string  FatherName { get; set; }
         public string  MotherName{get;set;}
         public string Address{get;set;}
         public int NoOfSiblings{get;set;}

         public DateTime DateOfJoining{get;set;} 

         
    }
}