using System;
namespace SingleInheritance;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("virat","kholi",98765454,"Virat@gmail.com",new DateTime(2000,09,08),Gender.Male,"I","CSE","2017-2021");
       
        student.ShowStudentInfo();
         student.UpdateInfo();
    }
}
