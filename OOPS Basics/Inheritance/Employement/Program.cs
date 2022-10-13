using System;
namespace Employement;
class Program{
    public static void Main(string[] args)
    {
        PersonnelDetails person1=new PersonnelDetails("virat","Kholi",Gender.Male,9800000000);
        PersonnelDetails person2=new PersonnelDetails("Hardik","Pandhya",Gender.Male,9800000001);
        person1.showDetails();
        person2.showDetails();

    }
}
