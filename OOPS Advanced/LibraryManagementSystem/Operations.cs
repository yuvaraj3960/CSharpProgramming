using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Operations
    {
        static UserDetails  CurrentUser=null;
        static List<BorrowDetails> borrowList =new List<BorrowDetails>();

        static List<BookDetails> bookList=new List<BookDetails>();
        static List<UserDetails> userList= new List<UserDetails>();
        public static void MainMenu()
        {
            string condition="yes";
            do
            {
                Console.WriteLine("1.User Registration 2.User Login 3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("User Registration");
                        Registration();

                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("User Login");
                        Login();
                        

                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit");
                        condition="no";
                        break;
                    }
                }
                
                
                
            }while(condition=="yes");
        }
        public static void Registration()
        {
            Console.WriteLine("Enter your name");
            string userName=Console.ReadLine();
            Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.WriteLine("Enter your Department");
            Department department=Enum.Parse<Department>(Console.ReadLine());
            Console.WriteLine("Enter your mobilenumber");
            long mobileNumber=long .Parse(Console.ReadLine());
            Console.WriteLine("Enter your MailId");
            string mailId=Console.ReadLine();

            UserDetails user1=new UserDetails(userName,gender,department,mobileNumber,mailId);
            userList.Add(user1);



        }
        public static void Default()
        {
            UserDetails user2=new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com");
            userList.Add(user2);
            UserDetails user3= new UserDetails("Priyadharshini",Gender.Female,Department.CSE,994444455,"priya@gmail.com");
            userList.Add(user3);
            BookDetails book1=new BookDetails("c#","Authur1",3);
            bookList.Add(book1);
            BookDetails book2=new BookDetails("HTML","Authur2",5);
            bookList.Add(book2);
            BookDetails book3= new BookDetails("CSS","Authur1",3);
            bookList.Add(book3);
            BookDetails book4=new BookDetails("JS","Authur1",3);
            bookList.Add(book4);
            BookDetails book5=new BookDetails("TS","Authur2",2);
            bookList.Add(book5);
            BorrowDetails borrow1=new BorrowDetails(book1.BookId,user2.RegisterNumber,DateTime.Now,Status.Issued);
            borrowList.Add(borrow1);
            BorrowDetails borrow2=new BorrowDetails(book2.BookId,user2.RegisterNumber,DateTime.Now,Status.Issued);
            borrowList.Add(borrow2);
            BorrowDetails borrow3=new BorrowDetails(book3.BookId,user2.RegisterNumber,DateTime.Now,Status.Issued);
            borrowList.Add(borrow3);
            BorrowDetails borrow4=new BorrowDetails(book4.BookId,user3.RegisterNumber,DateTime.Now,Status.Issued);
            borrowList.Add(borrow4);
            BorrowDetails borrow5=new BorrowDetails(book5.BookId,user3.RegisterNumber,DateTime.Now,Status.Issued);
            borrowList.Add(borrow5);
        }
        public static void Login()
        {
            Console.WriteLine("Enter your RegisterNumber");
            string id = Console.ReadLine();
            foreach(UserDetails users in userList)
            {
                if(users.RegisterNumber!=id)
                {
                    Console.WriteLine("Invalid UserId");
                }
                else
                {
                    Console.WriteLine("Login Successfull");
                    CurrentUser=users;
                    

                }

            }
            
        }
        public static void SubMenu()
        {
            string condition1="yes";
            do
            {
            Console.WriteLine("1.Borrow Book 2.Show Borrowed History 3.Return Books 4. Exit Submenu");
            int options = int.Parse(Console.ReadLine());
             switch(options)
             {
                case 1:
                {
                    Console.WriteLine("Borrow Book");
                    BorrowBook();

                    break;
                }
                case 2:
                {
                    Console.WriteLine("Show Borrowed History");
                    ShowHistory();


                    break;
                }
                case 3:
                {
                    Console.WriteLine("Return Book");
                    ReturnBook();

                    break;
                }
                case 4:
                {
                    Console.WriteLine("Exit SubMenu");
                    condition1="no";
                    break;
                }
             }
            }while (condition1=="yes");



        }
        public static void BorrowBook()
        {
            // Show the BookDetails by travesing it
            foreach(BookDetails books in bookList)
            {
                Console.WriteLine(books.BookId+"\t"+books.AuthurName+"\t"+books.BookCount);
            }
                //Ask the user to pick bookId

                Console.Write("Enter the BookId");
                string id1=Console.ReadLine();

                 //check the book count Availaibility if not traverse the Borrow details and get the return date and display to the user that book will be available at this date
            foreach(BookDetails books in bookList)
            {
                if (books.BookId==id1)
                {
                    if (books.BookCount==0)
                    {
                        Console.WriteLine("Book Unavailable");
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            if(books.BookId==borrow.BookId)
                            {
                               Console.WriteLine("Book Will be available at "+borrow.BorrowDate.AddDays(15));
                            }
                        }
                    }
                    else
                    {
                        int count=0;
                        foreach(BorrowDetails borrow in borrowList)
                        {
                        //if book available ,then check the user already borrowed any book , 3 books maximum,else allocated book and bookstatus as Issued
                        if (CurrentUser.RegisterNumber==borrow.RegisterNumber)
                        {
                            if(borrow.Status==Status.Issued)
                            {
                             count+=1;
                            }

                        }
                        if(count==3)
                        {
                            Console.WriteLine("You already Borrow maximum Book");
                        }
                        else
                        {
                            Console.WriteLine("Your BorrowId is "+borrow.BorrowId);
                             // store this data in BorrowDetails 
                            
                            books.BookCount-=1;
                            borrow.BookId=books.BookId;

                            borrow.Status=Status.Issued;
                            borrow.BorrowDate=DateTime.Now;

                        }

                        }

                    }
                }
            }

            
            

           
            
           
        }

        public static void ReturnBook()
        {
            int count1=0;
            

           // print the return date of the book for current Logged in user
           foreach(BorrowDetails borrow in borrowList)
           {
            if(CurrentUser.RegisterNumber==borrow.RegisterNumber)
            {
               
                DateTime borrowDate1=borrow.BorrowDate.AddDays(15);
                 Console.WriteLine(borrowDate1);

                //if the return date is exceed then pay fine amount @rs 1 per each book and calcualte the total price

                if(borrow.BorrowDate>borrowDate1)
                {
                    count1+=1;
                    TimeSpan borrow3=borrow.BorrowDate-borrowDate1;
                    
                    

                    
                }
                 
                
               

                
                
            
                


            }
           }
           
           // pay the amount if needed
           //change the status from issued to returned 

        }

        public static void ShowHistory()
        {
            foreach(BorrowDetails borrows in borrowList)
            {
               if (CurrentUser.RegisterNumber==borrows.RegisterNumber)
               {
                 Console.WriteLine(borrows.BorrowId+"\t"+borrows.BookId+"\t"+borrows.RegisterNumber+"\t"+borrows.BorrowDate+"\t"+borrows.Status);
               }
            }

        }
        
    }
}