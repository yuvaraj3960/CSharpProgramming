using System;

using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace CollageAdmission3
{
    public delegate void EventManager();//user defined delegate
    public static class Operation 
    { 
        public static string _eventName;
        public static event EventManager eventlink=null;//user defined event

        
       

        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operation.MainMenu);
            eventlink+=new EventManager(Files.WriteToFiles);

        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
         static StudentDetails1 currentStudent=null; 
       public static List<StudentDetails1> studentList=new List<StudentDetails1>();

       static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();

       static List<AdmissionDetails> admissionList= new List<AdmissionDetails>();
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Department Seat Availability");
                        DepartmentSeatAvailability();
                        break;
                    }
                   
                    case 4:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
      

            public static void Registration()
            {
               Console.WriteLine("Enter Your Name");
               string name=Console.ReadLine();

               Console.WriteLine("Enter your Father's name");
               string fatherName=Console.ReadLine();

        
               Console.WriteLine("Enter your DOB:");
               DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

              Console.WriteLine("Enter your Gender:");
              Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);


              Console.WriteLine("Enter your Physics mark:");
              int  physics=int.Parse(Console.ReadLine());

              Console.WriteLine("Enter your Chemistry mark:");
              int  chemistry=int.Parse(Console.ReadLine());

               Console.WriteLine("Enter your Maths mark:");
               int  maths=int.Parse(Console.ReadLine());

              


                
            

               StudentDetails1 student1= new StudentDetails1(name,fatherName,dob,gender,physics,chemistry,maths);
               studentList.Add(student1);
               
               Console.WriteLine("Your Registration number is "+student1.StudentId);
            }

            public static void Login()
            {
                Console.WriteLine("Enter Your Register Number");
                String register=Console.ReadLine();

                foreach(StudentDetails1 student in studentList)
                {
                    if(student.StudentId==register)
                    {
                        Console.WriteLine("Login Successful");
                        currentStudent=student;
                        SubMenu();


                    }
                }



            }
            
            public static void SubMenu()
            {
                string choice1="yes";
                do{
                Console.WriteLine("Select 1.ShowDetails,2.TakeAdmission,3.CancelAdmission,4.EXit SubMenu");
                int option1=int.Parse(Console.ReadLine());

                switch(option1)
                {
                    case 1:
                    {
                        Console.WriteLine("ShowDetails");
                        currentStudent.ShowDetails();
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("Take Admission");
                        TakeAdmission();
              
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Cancel Admission");
                        CancelAdmission();
                        break;
                    }
                    case 4:
                   { 
                      Console.WriteLine("Exit SubMenu");
                      choice1="no";
                      break;
                    }
             }
            }while(choice1=="yes");
                 
           }

            public static void Default()
            {  //Add Default values to the studentList
                StudentDetails1 student1=new StudentDetails1("Ravichandran","Ettaparajan",new DateTime(2022,11,11),Gender.Male,95,95,95);
                studentList.Add(student1);
                StudentDetails1 student2= new StudentDetails1("Baskaran","Sethurajan", new DateTime(1999,11,11),Gender.Male,95,95,95);
                
                studentList.Add(student2);
                //Add Default values to the departmentlist

                DepartmentDetails departments=new DepartmentDetails("EEE",29);
                departmentList.Add(departments);
                DepartmentDetails departments1=new DepartmentDetails("CSE",29);
                departmentList.Add(departments1);
                DepartmentDetails departments2= new DepartmentDetails("MECH",29);
                departmentList.Add(departments2);
                DepartmentDetails departments3= new DepartmentDetails("ECE",29);
                departmentList.Add(departments3);

                //Add Default values to the Admissionlist

                AdmissionDetails admission1=new AdmissionDetails( student1.StudentId,departments.DepartmentId,new DateTime(2022,05,11),AdmissionProcess.Admitted);
                admissionList.Add(admission1);
                AdmissionDetails admission2= new AdmissionDetails(student1.StudentId,departments.DepartmentId,new DateTime(2022,05,11),AdmissionProcess.Admitted);
                admissionList.Add(admission2);

             }
             public static void TakeAdmission()
             {
                // Display the Department details 

                foreach(DepartmentDetails dept in departmentList)
                {
                    Console.WriteLine(dept.DepartmentId+"\t"+dept.DepartmentName+"\t"+dept.NumberOfSeats);
                }
                //enter the Department id
                Console.WriteLine("Choose the Department by entering the Department ID");
                string id=Console.ReadLine();

                //pick that department id object 

                foreach(DepartmentDetails dept in departmentList)
                {
                    if(dept.DepartmentId==id)
                    {
                        //check eligibility
                       
                        
                        if(dept.NumberOfSeats>=1)
                        {
                        bool eligible=currentStudent.CheckEligibility(75.0);

                        if(eligible)
                        {
                            bool canAdmit=true;
                            
                            Console.WriteLine("You are eligible for Admission");
                            
                            foreach(AdmissionDetails admt in admissionList)
                             {
                                if(currentStudent.StudentId==admt.StudentId)
                                {
                                        if(admt.AdmissionStatus==AdmissionProcess.Admitted)
                                    {
                                        // already Admission exists
                                           Console.Write("Your Admission already exists");
                                           canAdmit=false;
                                     }
                                }

                             }
                                      if(canAdmit)
                                     {
                                          //if not reduce count by 1
                                           dept.NumberOfSeats-=1;
                                             AdmissionDetails admission1=new AdmissionDetails(currentStudent.StudentId,dept.DepartmentId, DateTime.Now,AdmissionProcess.Admitted);
                                             admissionList.Add(admission1);

                                            Console.WriteLine("Admission Successfully finished");
                                             Console.WriteLine("Your AdmissionId is "+admission1.AdmissionId);
                            

                                    }      
                                }
                     
                                    

                                
                        
                                else{
                                   Console.WriteLine("You are not eligible");
                                     }
                        }    
                             
                    } 
                    

                    
                    else
                    {
                        Console.WriteLine("Wrong ID");
                    }
                    
                
                }
                
             }

             public static void CancelAdmission()
             {
                //Show the CurrentLogged Student's Admission List
                 foreach(AdmissionDetails admt in admissionList)
                 {
                    if(currentStudent.StudentId==admt.StudentId)
                    {
                        Console.WriteLine(admt.AdmissionStatus);
                        //If booked change it to Cancelled
                        if(admt.AdmissionStatus==AdmissionProcess.Admitted)
                        {
                            //return the seat to Department List
                            admt.AdmissionStatus=AdmissionProcess.Admitted;
                            foreach(DepartmentDetails dept in departmentList)
                            {
                                if(admt.DepartmentId==dept.DepartmentId)
                                {
                                    dept.NumberOfSeats+=1;
                                    Console.WriteLine("Admission Cancelled successfully");
                                }
                            
                                
                            }

                        }
                        else
                        {
                            //Finally Show the Message As Cancelled
                            Console.WriteLine("Already Cancelled");
                        }
                            
                        
                    }
                 }
                 
                 
                 
                
                 
                
             }
             public static void DepartmentSeatAvailability()
             {
                foreach(DepartmentDetails Seats in departmentList)
                {
                    Console.WriteLine(Seats.DepartmentId+"\t"+Seats.DepartmentName+"\t"+Seats.NumberOfSeats);
                }
             }

   }   
   
}                        
                


     
               
                
                

         
                
                
             
             
          



                    

    
    
    
      
    
