using System;

namespace MovieTicketBooking;
class Operation{
       
         

            public  static List<UserDetails> userList=new List<UserDetails>();
            public  static List<TheatreDetail> theatreList=new List<TheatreDetail>();
            public static List<MovieDetails> movieList=new List<MovieDetails>();
            public static List <ScreeningDetails> screeningList=new List<ScreeningDetails>();
            public   static List <BookingDetails> bookingList=new List<BookingDetails>();

            static UserDetails CurrentUser;
    public static void MainMenu()
    {

   
        
        string condition="yes";
        do{
        System.Console.WriteLine("Entering into the MainMenu");
        System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
        int option = int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("UserRegistration");
                UserRegistration();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Login");
                Login();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Exit");
                condition="no";
                break;
            }
        }
         System.Console.WriteLine("Do you want to Continue the Process");
         condition=Console.ReadLine().ToLower();
             
        }while(condition=="yes");
        
      
        //BookingDetail();

        
    }
    public static void AddDefault()
    {
        UserDetails user1=new UserDetails("RaviChandran",30,8599488003,1000);
        userList.Add(user1);
        UserDetails user2=new UserDetails("Baskaran",30,9857747327,1000);
        userList.Add(user2);

        TheatreDetail theatre1=new TheatreDetail("Inox","AnnaNagar");
        theatreList.Add(theatre1);
        TheatreDetail theatre2=new TheatreDetail("Ega Theatre","Chetpet");
         theatreList.Add(theatre2);
        TheatreDetail theatre3=new TheatreDetail("Kamala","Vadapalani");
         theatreList.Add(theatre3);

        MovieDetails movie1=new MovieDetails("bagubali 2","Telugu");
        movieList.Add(movie1);
        MovieDetails movie2=new MovieDetails("Ponniyin Selvan","Tamil");
        movieList.Add(movie2);
        MovieDetails movie3=new MovieDetails("Cobra","Tamil");
        movieList.Add(movie3);
        MovieDetails movie4=new MovieDetails("Vikram","HindiDubbed");
        movieList.Add(movie4);
        MovieDetails movie5=new MovieDetails("Vikram","Tamil");
        movieList.Add(movie5);
        MovieDetails movie6=new MovieDetails("Beast","English");
        movieList.Add(movie6);


        ScreeningDetails screen1=new ScreeningDetails(movie1.MovieId,theatre1.TheatreId,5,200);
        screeningList.Add(screen1);
        ScreeningDetails screen2=new ScreeningDetails(movie2.MovieId,theatre1.TheatreId,2,300);
        screeningList.Add(screen2);
        ScreeningDetails screen3=new ScreeningDetails(movie6.MovieId,theatre1.TheatreId,1,50);
        screeningList.Add(screen3);
        ScreeningDetails screen4=new ScreeningDetails(movie1.MovieId,theatre2.TheatreId,11,400);
        screeningList.Add(screen4);
        ScreeningDetails screen5=new ScreeningDetails(movie2.MovieId,theatre2.TheatreId,20,300);
        screeningList.Add(screen5);
        ScreeningDetails screen6=new ScreeningDetails(movie4.MovieId,theatre2.TheatreId,2,500);
        screeningList.Add(screen6);
        ScreeningDetails screen7=new ScreeningDetails(movie5.MovieId,theatre3.TheatreId,11,100);
        screeningList.Add(screen7);
        ScreeningDetails screen8=new ScreeningDetails(movie2.MovieId,theatre3.TheatreId,20,200);
        screeningList.Add(screen8);
        ScreeningDetails screen9=new ScreeningDetails(movie4.MovieId,theatre3.TheatreId,2,350);
        screeningList.Add(screen9);

        BookingDetails bookings1=new BookingDetails(user1.UserId,movie1.MovieId,theatre1.TheatreId,1,200,BookingStatus.Booked);
        bookingList.Add(bookings1);
        
        BookingDetails bookings2=new BookingDetails(user1.UserId,movie4.MovieId,theatre2.TheatreId,1,400,BookingStatus.Booked);
        bookingList.Add(bookings2);
        
        BookingDetails bookings3=new BookingDetails(user2.UserId,movie5.MovieId,theatre2.TheatreId,1,300,BookingStatus.Booked);
        bookingList.Add(bookings3);
        
    }

    public static void BookingDetail()
     {
        foreach(BookingDetails booking in bookingList)
        {
           booking.BookingDetail();
        }
     }

     public static void UserRegistration()
     {
        System.Console.WriteLine("Enter Your Name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Age");
        int age= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Your PhoneNumber");
        long phoneNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your WalletBalance");
        double balance=double.Parse(Console.ReadLine());

        UserDetails user3=new UserDetails(name,age,phoneNumber,balance);
        userList.Add(user3);

        System.Console.WriteLine("Your UserId "+user3.UserId);

     }

     public static void Login()
     {
        int flag=0;
        System.Console.WriteLine("Login Process");
        System.Console.WriteLine("Enter your UserId");
        string id =Console.ReadLine();
        foreach(UserDetails user in userList)
        {
            if(user.UserId==id)
            {
                flag=1;
                CurrentUser=user;
                System.Console.WriteLine("Login Successfull");
                SubMenu();

                
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid UserId");
        }
       
     }

     public static void SubMenu()
     {
        string condition="yes";
        do{
        System.Console.WriteLine("SubMenu");
        System.Console.WriteLine("1.Ticket Booking 2.Ticket Cancellation 3.Booking History 4.Wallet Recharge 5.Exit SubMenu");
        int option= int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Ticket Booking");
                TicketBooking();

                break;
            }
            case 2:
            {
                System.Console.WriteLine("Ticket Cancellation");
                TicketCancellation();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Booking History");
                BookingHistory();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("WalletRecharge");
                CurrentUser.RechargeWallet(CurrentUser.WalletBalance);
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exit");
                condition="no";
                break;
            }
        }
        

        }while(condition=="yes");

        
     }

     public static void TicketBooking()
        {
            
            int flag1=0;
            double amount=0;
           
            foreach(TheatreDetail theatres in theatreList)
            {
                System.Console.WriteLine("Theatre List");
                System.Console.WriteLine(theatres.TheatreId+"\t"+theatres.TheatreName+"\t"+theatres.TheatreLocation);
            }
            foreach(MovieDetails movies in movieList)
            {
                System.Console.WriteLine("Movie List");
                System.Console.WriteLine(movies.MovieId+"\t"+movies.MovieName+"\t"+movies.MovieLanguage);
            }
            foreach(ScreeningDetails screenings in screeningList)
            {
                System.Console.WriteLine("Screening List");
                System.Console.WriteLine(screenings.MovieId+"\t"+screenings.TheatreId+"\t"+screenings.NoOfSeatAvailable+"\t"+screenings.TicketPrice);
            }

           

            System.Console.WriteLine("Enter the Theartre Id");
            string id =Console.ReadLine();
            foreach(TheatreDetail theatres in theatreList)
            {
                if(theatres.TheatreId==id)
                {
                    foreach(ScreeningDetails screenings in screeningList)
                    {
                        if(theatres.TheatreId==screenings.TheatreId)
                        {
                          

                            foreach(MovieDetails movies in movieList)
                            {
                                if(movies.MovieId==screenings.MovieId)
                                {
                                    System.Console.WriteLine(movies.MovieId+"\t"+movies.MovieName+"\t"+movies.MovieLanguage);

                                    

                                }
                            }
                            break;

                        }

                    }
                            System.Console.WriteLine("Enter the MovieId");
                            string moviesid=Console.ReadLine();
                            
                        foreach(ScreeningDetails screenings in screeningList)
                        {

                            if(moviesid==screenings.MovieId)
                            {
                              
                              
                                System.Console.WriteLine("Enter the no of seats");
                                int count=int.Parse(Console.ReadLine());

                                 if(screenings.NoOfSeatAvailable>=count)
                                  {
                                    
                                
                                    amount=count*screenings.TicketPrice;
                                    amount+=100*(18/amount);
                                    if(CurrentUser.WalletBalance>=amount)
                                    {
                                        CurrentUser.WalletBalance-=amount;
                                        flag1=1;
                                        
                                        screenings.NoOfSeatAvailable-=count;
                                        
                                        foreach(BookingDetails bookings in bookingList)
                                        {
                                            bookings.BookingStatus1=BookingStatus.Booked;
                                            BookingDetails bookings5=new BookingDetails(CurrentUser.UserId,moviesid,id,count,amount,bookings.BookingStatus1);
                                            bookingList.Add(bookings5);
                                            System.Console.WriteLine("Your Booking Id "+bookings.BookingId);
                                            System.Console.WriteLine("Booking Successful");
                                            break;
                                            
                                           
                                        }

                                    }
                                }
                                else
                                {
                                       
                                    System.Console.WriteLine("Seats unavailable, current Availability {0}",screenings.NoOfSeatAvailable);
                                  

                                
                                }      
                                   
                                    

                            }
                            else
                            {
                                System.Console.WriteLine("Invalid Movie Id");
                            }
                                
                               
                            
                        
                        
                            
                        }

                           
                        }
                     
                    }
                
            
            
            if(flag1==0)

             {
               
                System.Console.WriteLine("Insufficient Balance , please Recharge");
                                         
             }
            
          

        }

        public static void TicketCancellation()
        {
            double amount=0;
            int counts=0;
            // show the current looged users bookings
            foreach(BookingDetails bookings in bookingList)
            {
                if(CurrentUser.UserId==bookings.UserId)
                {
                    System.Console.WriteLine(bookings.BookingId+"\t"+bookings.UserId+"\t"+bookings.MovieId+"\t"+bookings.TheatreId+"\t"+bookings.SeatCount+"\t"+bookings.TotalAmount+"\t"+bookings.BookingStatus1);
                }
            }

            System.Console.WriteLine("Enter the booking Id which You want to cancel");
            string id=Console.ReadLine();
                    //check the Booking status  
             foreach(BookingDetails bookings in bookingList)
            {
                if(bookings.BookingId==id)
                {
            
                if(bookings.BookingStatus1==BookingStatus.Booked)
                {
                    //get the count of the seats
                    counts=bookings.SeatCount;
                    foreach(ScreeningDetails screenings in screeningList)
                    {
                        if(screenings.MovieId==bookings.MovieId)
                        {
                        screenings.NoOfSeatAvailable+=counts;
                        }
                    }
                      amount=bookings.TotalAmount-20;
                      CurrentUser.WalletBalance+=amount;

                      bookings.BookingStatus1=BookingStatus.Cancelled;
                 }
                }
            }
            
       }

       public static void BookingHistory()
       {
        foreach(BookingDetails bookings in bookingList)
        {
            if(CurrentUser.UserId==bookings.UserId)
            {
                System.Console.WriteLine(bookings.BookingId+"\t"+bookings.UserId+"\t"+bookings.MovieId+"\t"+bookings.TheatreId+"\t"+bookings.SeatCount+"\t"+bookings.TotalAmount+"\t"+bookings.BookingStatus1);
            }
        }
       }

}

