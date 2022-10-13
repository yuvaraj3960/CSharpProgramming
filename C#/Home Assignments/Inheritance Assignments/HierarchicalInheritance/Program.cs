using System;
namespace HierarchicalInheritance;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Virat","Kholi",987654322,"Virat@123",new DateTime(2000,08,08),Gender.Male,"B.E",Department.CSE,"Five");
        student.ShowStudentInfo();
        student.UpdateInfo();
        TeacherInfo teacher = new TeacherInfo("Virat","Kholi",9876543321,"virat@123",new DateTime(2000,08,08),Gender.Male,Department.CSE,"Data Structures","B.E",5,new DateTime(2022,08,08));
        teacher.ShowTeacherInfo();
        teacher.UpdateTeacherInfo();

    }
}
