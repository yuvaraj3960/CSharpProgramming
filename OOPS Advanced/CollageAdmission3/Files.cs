using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission3
{
    public static class Files
    {
        public static void create()
        {
            if(!Directory.Exists("College"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");

            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                Console.WriteLine("Creating file");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetails.csv");

            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string[] student=File.ReadAllLines("College/StudentDetails.csv");

            foreach(string data in student)
            {
                StudentDetails1 students=new StudentDetails1(data);
                Operation.studentList.Add(students);
                

            }
        }
        public static void WriteToFiles()   
        {
            string[] studentDetails1=new string [Operation.studentList.Count];
            for(int i=0;i<Operation.studentList.Count;i++)
            {
                studentDetails1[i]=Operation.studentList[i].StudentId+","+Operation.studentList[i].StudentName+","+Operation.studentList[i].FatherName+","+Operation.studentList[i].DOB+","+Operation.studentList[i].Gender+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails1);
        }
        
        }
}
