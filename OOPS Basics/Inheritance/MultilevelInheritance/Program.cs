using System;
namespace MultilevelInheritance;
class Program{
    public static void Main(string[] args)
    {
        PersonnelDetails person1=new PersonnelDetails("virat","Kholi",Gender.Male,9800000000);
        PersonnelDetails person2=new PersonnelDetails("Hardik","Pandhya",Gender.Male,9800000001);
        person1.showDetails();
        person2.showDetails();
        StudentDetails1 student=new StudentDetails1("`112345","virat","kholi",Gender.Male,345678,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,90);
        student.Calculate();
        student.ShowDetails1();
        CustomerDetails customer=new CustomerDetails("45678678","virat","Kholi",Gender.Male,5678900);
        customer.showCustomer();
        EmployementDetails employee=new EmployementDetails(student.StudentId,person1.AadharId,"virat","kholi",Gender.Male,8888,Department.CSE);
        employee.showEmployee();
        employee.ShowStudent();
        
        //employee.GetMark(90,90,90);

    }
}
