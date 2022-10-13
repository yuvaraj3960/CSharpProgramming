using System;
namespace StudentDetails;

    class Program
    {
      public static void Main(string[] args)
     {
        Console.WriteLine("Enter the Student name:");
        string name=Console.ReadLine();
        Console.WriteLine("Your Name is "+name);
        Console.WriteLine("Enter the Father name:");
        string fname=Console.ReadLine();
        Console.WriteLine("Your Father name is "+fname);
        Console.WriteLine("Enter the valid Mail ID:");
        string mail=Console.ReadLine();
        Console.WriteLine("Your Mail ID is  "+mail);
        Console.WriteLine("Enter the Phone number:");
        long ph=Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Your phone number is"+ph);
        Console.WriteLine("Enter an age:");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is"+age);
        Console.WriteLine("Enter the Gender:");
        char gender= Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Your Gender is "+gender);

        Console.WriteLine("Enter the marks in chemistry:");
        int chemistry=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your chemistry marks:"+chemistry);
        Console.WriteLine("Enter the marks in physics:");
        int physics=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your physics marks:"+physics);
        Console.WriteLine("Enter the marks in maths:");
        int maths=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your physics marks:"+maths);
        int sum=chemistry+physics+maths;
        float average= (float)sum/3;
        Console.WriteLine("Average is "+average);
        float percentage=(float) sum/600*100;
        Console.WriteLine("Percentage is "+percentage+"%");





        


       


     } 
    }

   


    
    

