using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication;

public class Operations{
    public static void MainMenu()
    {
        
        List<StudentDetails> studentList=new List<StudentDetails>();
        string willing="";
       /* do{
            Console.WriteLine("read");
        StudentDetails student1=new StudentDetails();
        
        Console.WriteLine("Enter the StudentName:");
          student1.Name=Console.ReadLine();

         Console.WriteLine("Enter your FatherName:");
        student1.FatherName=Console.ReadLine();

        Console.WriteLine("Enter your DOB:");
        student1.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter your Gender:");
        student1.Gender=Console.ReadLine();

        Console.WriteLine("Enter your PhoneNumber:");
        student1.Phone=long.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter your MailId :");
         student1.Mail=Console.ReadLine();

           Console.WriteLine("Enter your Physics mark:");
           student1.Physics=int.Parse(Console.ReadLine());

           Console.WriteLine("Enter your Chemistry mark:");
            student1.Chemistry=int.Parse(Console.ReadLine());

           Console.WriteLine("Enter your Maths mark:");
           student1.Maths=int.Parse(Console.ReadLine());
           studentList.Add(student1);
            Console.WriteLine("Are you willing to join in this college:");
            willing=Console.ReadLine().ToLower();

           Console.WriteLine("Admitted");
        }while(willing=="yes");*/

         do{
            Console.WriteLine("read");
       
        
        Console.WriteLine("Enter the StudentName:");
        string name=Console.ReadLine();

         Console.WriteLine("Enter your FatherName:");
         string fatherName=Console.ReadLine();

        Console.WriteLine("Enter your DOB:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter your Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        Console.WriteLine("Enter your PhoneNumber:");
        long phone=long.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter your MailId :");
        string mail=Console.ReadLine();

           Console.WriteLine("Enter your Physics mark:");
           int  physics=int.Parse(Console.ReadLine());

           Console.WriteLine("Enter your Chemistry mark:");
           int  chemistry=int.Parse(Console.ReadLine());

           Console.WriteLine("Enter your Maths mark:");
           int  maths=int.Parse(Console.ReadLine());
           StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,phone,mail,physics,chemistry,maths);
           studentList.Add(student1);
            Console.WriteLine("Are you willing to join in this college:");
            willing=Console.ReadLine().ToLower();

           Console.WriteLine("Admitted");
        }while(willing=="yes");

         /*  StudentDetails student2=new StudentDetails();
        
        Console.WriteLine("Enter the StudentName:");
        student2.Name=Console.ReadLine();

         Console.WriteLine("Enter your FatherName:");
        student2.FatherName=Console.ReadLine();

        Console.WriteLine("Enter your DOB:");
        student2.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter your Gender:");
        student2.Gender=Console.ReadLine();

        Console.WriteLine("Enter your PhoneNumber:");
        student2.Phone=long.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter your MailId :");
        student2.Mail=Console.ReadLine();

        Console.WriteLine("Enter your Physics mark:");
       student2.Physics=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Chemistry mark:");
        student2.Chemistry=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Maths mark:");
       student2.Maths=int.Parse(Console.ReadLine());

       StudentDetails student3=new StudentDetails();


        Console.WriteLine("Enter the StudentName:");
        student3.Name=Console.ReadLine();

         Console.WriteLine("Enter your FatherName:");
        student3.FatherName=Console.ReadLine();

        Console.WriteLine("Enter your DOB:");
        student3.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.WriteLine("Enter your Gender:");
        student3.Gender=Console.ReadLine();

        Console.WriteLine("Enter your PhoneNumber:");
        student3.Phone=long.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter your MailId :");
        student3.Mail=Console.ReadLine();

        Console.WriteLine("Enter your Physics mark:");
        student3.Physics=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Chemistry mark:");
        student3.Chemistry=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Maths mark:");
        student3.Maths=int.Parse(Console.ReadLine());*/

        
       // studentList.Add(student2);
       // studentList.Add(student3);
        


        foreach(StudentDetails student in studentList)
        {
        Console.WriteLine("Your Name is:"+student.Name);
        Console.WriteLine("Your FatherName is:"+student.FatherName);
        Console.WriteLine("Your DOB is:"+student.DOB);
        Console.WriteLine("Your Gender is:"+student.Gender);
        Console.WriteLine("Your Phone is:"+student.Phone);
        Console.WriteLine("Your Mail is:"+student.Mail);
        Console.WriteLine("Your Physics mark is:"+student.Physics);
        Console.WriteLine("Your Chemistry is:"+student.Chemistry);
        Console.WriteLine("Your Maths mark is:"+student.Maths);
        Console.WriteLine("Your RegisterNumber is:"+student.RegisterNumber);
        bool eligible=student.CheckEligibility(75.0);
        if(eligible)
        {
            Console.WriteLine("You are eligible for admission");
        }
        else{
            Console.WriteLine("You arenot elegible for admission");
        }
        }


        /*Console.WriteLine("Your Name is:"+student2.Name);
        Console.WriteLine("Your FatherName is:"+student2.FatherName);
        Console.WriteLine("Your DOB is:"+student2.DOB);
        Console.WriteLine("Your Gender is:"+student2.Gender);
        Console.WriteLine("Your Phone is:"+student2.Phone);
        Console.WriteLine("Your Mail is:"+student2.Mail);
        Console.WriteLine("Your Physics mark is:"+student2.Physics);
        Console.WriteLine("Your Chemistry is:"+student2.Chemistry);
        Console.WriteLine("Your Maths mark is:"+student2.Maths);

        Console.WriteLine("Your Name is:"+student3.Name);
        Console.WriteLine("Your FatherName is:"+student3.FatherName);
        Console.WriteLine("Your DOB is:"+student3.DOB);
        Console.WriteLine("Your Gender is:"+student3.Gender);
        Console.WriteLine("Your Phone is:"+student3.Phone);
        Console.WriteLine("Your Mail is:"+student3.Mail);
        Console.WriteLine("Your Physics mark is:"+student3.Physics);
        Console.WriteLine("Your Chemistry is:"+student3.Chemistry);
        Console.WriteLine("Your Maths mark is:"+student3.Maths);*/














        
    }
}
