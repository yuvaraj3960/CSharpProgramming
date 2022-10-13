using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetailz
    {
        public StudentDetailz()
        {
            StudentId="SF3001";
            StudentName="Ravichandran";
            FatherName="Ettaparajan";
            DateTime DOB= new DateTime(11/11/1999);
           Gender =Gender.Male;
           Physics=95;
           Chemistry=95;
           Maths=95;
        }
       


        public StudentDetailz(string name,string fatherName,DateTime dob,Gender gender,double physics,double chemistry,double maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;

            StudentName=name;
            FatherName=FatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Maths=maths;
        }
    }
}