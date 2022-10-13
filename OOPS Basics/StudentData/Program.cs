using System;
namespace StudentData;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo.Display();
        StudentInfo.RegisterNumber=3961;
        Console.WriteLine(StudentInfo.RegisterNumber);
    }
}
