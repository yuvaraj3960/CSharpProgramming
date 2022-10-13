using System;
using System.Collections.Generic;
namespace OnlineGroceries;

class Operation{

    
    public  static List<ProductDetail> productList= new List<ProductDetail>();
     public   static List<BookingDetail> bookingList= new List<BookingDetail>();
     public   static List<OrderDetail> orderList=new List<OrderDetail>();

      public   static List<CustomerDetail> customerList=new List<CustomerDetail>();
         static CustomerDetail CurrentCustomer;
   
    public static void MainMenu()
    {
        AddDefault();
        string condition="yes";

        do{
             System.Console.WriteLine("Main Menu");      
        System.Console.WriteLine("1.Customer Registration" +"\n"+"2.Customer Login"+"\n"+ "3.Exit MainMenu");
        
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                //System.Console.WriteLine("You Have Selected Registration Process");
                CustomerRegistration();
                break;
            }
            case 2:
            {
               // System.Console.WriteLine("You have Selected Login Process");
                CustomerLogin();
                
                break;
            }
            case 3:
            {
                condition="no";
               
                
               
                break;
            }

        }
       
        }while(condition=="yes");
        
      
        
                    


           
        
    }

    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Customer Registration Method Called");
        System.Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter Your FatherName");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter your Gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter your MObile Number");
        long mobile=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your DAte of Birth ");
        DateTime dob= DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your MAilId");
        string mailId=Console.ReadLine();

        CustomerDetail customer3=new CustomerDetail(name,fatherName,gender,mobile,dob,mailId);
        customerList.Add(customer3);

        System.Console.WriteLine("CustomerId"+customer3.CustomerId);



    }

    public static void CustomerLogin()
    {
        int count=0;
        System.Console.WriteLine("Customer Login Method called");

        System.Console.WriteLine("Enter your Customer ID");
        string id=Console.ReadLine().ToUpper();

        foreach(CustomerDetail cust in customerList)
        {
            if(cust.CustomerId==id)
            {
                
                CurrentCustomer=cust;
                System.Console.WriteLine("LoginSuccessful");
                count=1;
                SubMenu();
            }
            
        }
        if(count==0)
        {
            System.Console.WriteLine("Invalid UserID");
        }
        
        

    }

    public static void SubMenu()
    {
        string condition="yes";
        do{
            System.Console.WriteLine("SubMenu");
            System.Console.WriteLine("1.Show Customer Details"+"\n"+ "2.Show Product Detail"+"\n"+  "3.Wallet Recharge"+"\n"+" 4.Take Order"+"\n"+" 5.Modify Order"+"\n"+" 6. Cancel Order"+"\n"+" 7.Exit ");
            int option=int.Parse(Console.ReadLine());

            switch(option){
        
               case 1:
                  { System.Console.WriteLine("Show Customer Details");
                     CurrentCustomer.ShowCustomerDetails();
                   break;
                   }
                case 2:
                   {
                      System.Console.WriteLine("Show Product Detail");
                      ShowProductDetails();
                      
                      break;
                   }
                 case 3:
                 {
                System.Console.WriteLine("Wallet Recharge");
                CurrentCustomer.WalletRecharge();

                break;
                 }
                case 4:
                {
                System.Console.WriteLine("Take Order");
                TakeOrder();
                break;
                 }
                case 5:
                {
                System.Console.WriteLine("Modify Order");
                ModifyOrder();
                break;
                }
                case 6:
                {
                System.Console.WriteLine("Cancel Order");
                CancelOrder();
                break;
                }
                case 7:
                 {
                System.Console.WriteLine("Exit");
                condition="no";
                break;
                 }

        }
        }while(condition=="yes");
        
        
    }

    public static void AddDefault()
    {
         CustomerDetail customer1=new CustomerDetail("Ravi","Chandran",Gender.Male,987655432,new DateTime(1999,11,11),"ravi@gmail.com");
         CustomerDetail customer2=new CustomerDetail("Baskaran","Sethurajan",Gender.Male,98765434321,new DateTime(1999,11,11),"baskaran@gmail.com");

            customerList.Add(customer1);
            customerList.Add(customer2);


             //Product Details Data
            ProductDetail product1=new ProductDetail("Sugar",20,40);
            ProductDetail product2=new ProductDetail("Rice",100,50);
            ProductDetail product3=new ProductDetail("Milk",10,40);
            ProductDetail product4=new ProductDetail("Coffee",10,10);
            ProductDetail product5=new ProductDetail("Tea",10,10);
            ProductDetail product6=new ProductDetail("Masala Powder",10,20);
            ProductDetail product7=new ProductDetail("Salt",10,10);
            ProductDetail product8=new ProductDetail("Turmeric Powder",10,25);
            ProductDetail product9=new ProductDetail("Chilli Powder",10,20);
            ProductDetail product10=new ProductDetail("Groundnut Oil",10,140);

            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);

            //Booking Details Data

            BookingDetail booking1=new BookingDetail(customer1.CustomerId,220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetail booking2=new BookingDetail(customer2.CustomerId,400,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetail booking3=new BookingDetail(customer1.CustomerId,280,new DateTime(2022,07,22),BookingStatus.Cancelled);
            BookingDetail booking4=new BookingDetail(customer2.CustomerId,0,new DateTime(2022,07,22),BookingStatus.Initiated);

            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);

            //OrderDetail Data
            OrderDetail order=new OrderDetail(booking1.BookingId,product1.ProductId,2,80);
            OrderDetail order1=new OrderDetail(booking1.BookingId,product2.ProductId,2,100);
            OrderDetail order2=new OrderDetail(booking1.BookingId,product3.ProductId,1,40);
            OrderDetail order3=new OrderDetail(booking2.BookingId,product1.ProductId,1,40);
            OrderDetail order4=new OrderDetail(booking2.BookingId,product2.ProductId,4,200);

            orderList.Add(order);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);

              
    

   
                    
                    
    }
    
    public static void ShowProductDetails()
    {
        foreach(ProductDetail products in productList)
        {
            products.ShowProductDetails();
        }
    }

  
    public static void TakeOrder()
    {
        
        
        string proceed="yes";
        double totalPrice=0;
        int flag=0;
        
        string condition="yes";


        System.Console.WriteLine("TakeOrder method Called");
         
        //Create a Booking object

        BookingDetail booking1=new BookingDetail(CurrentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
        List<OrderDetail> tempOrderList=new List<OrderDetail>();

        do{
          //Show Product Details
           System.Console.WriteLine("Showing Product Details");
           ShowProductDetails();
           //get the input from the user about product id and check
           System.Console.WriteLine("Select the Products from the Above List by giving the Product ID");
           string id = Console.ReadLine();

        
            foreach(ProductDetail products in productList)
             {
                if(products.ProductId==id)
              {
                flag=1;
                //get the Quantity and check
                System.Console.WriteLine("Enter the quantity to check ");
                 int quantity=int.Parse(Console.ReadLine());
                if(products.QuantityAvailable>=quantity)
                {
                    
                    
                    double total=quantity*products.PricePerQuantity;
                    
                     //Take the order & create the object and add in local order list.
                    
                     System.Console.WriteLine("Items Successfully added in cart");
                     products.QuantityAvailable-=quantity;
                     OrderDetail order=new OrderDetail(booking1.BookingId,id,quantity,total);
                     tempOrderList.Add(order);

                    

                }
                else
                {
                    
                        System.Console.WriteLine("Quantity unavailable");
                    
                }

            }
           
        }

        if(flag==0)
        {
            System.Console.WriteLine("Invalid Product Id");
        }
        
        System.Console.WriteLine("Do want to continue the purchase");
        condition=Console.ReadLine();

        }while (condition=="yes");

        foreach(OrderDetail orders in tempOrderList)
        {
             totalPrice+=orders.PriceOfOrder;
        }
        System.Console.WriteLine("Do you want to purchase the orders");
        condition=Console.ReadLine();
        if(condition=="yes")
        {
            while(proceed=="yes")
            {
                 //Calculate the price and compare the wallet

                if(CurrentCustomer.WalletBalance>=totalPrice)
                {
                    CurrentCustomer.WalletBalance-=totalPrice;
                     System.Console.WriteLine("order Successful");
                    
                     System.Console.WriteLine("BookingId "+booking1.BookingId);
                    
                   
                    booking1.BookingStatus1=BookingStatus.Booked;
                    booking1.TotalPrice=totalPrice;
                    bookingList.Add(booking1);
                   
                   
                    orderList.AddRange(tempOrderList);
                    proceed="no";


                }
                else
                {
                    System.Console.WriteLine("Insufficient Balance");
                    CurrentCustomer.WalletRecharge();
                }
            }
        }
        else
        {
            foreach(OrderDetail orders in tempOrderList)
            {
                foreach(ProductDetail products in productList)
                {
                    if(products.ProductId==orders.ProductId)
                    {
                        products.QuantityAvailable+=orders.PurchaseCount;
                    }
                }
               
            }
            System.Console.WriteLine("Cart removed Successfully");
            
            
        }
        
        


        
       
       

    }

    public static void ModifyOrder()
    {
        double price=0;
        System.Console.WriteLine("Modify order method called");
        foreach(BookingDetail bookings in bookingList)
        {
            if(CurrentCustomer.CustomerId==bookings.CustomerId)
            {
                System.Console.WriteLine(bookings.BookingId+"\t"+bookings.CustomerId+"\t"+bookings.TotalPrice+"\t"+bookings.DateOfBooking+"\t"+bookings.BookingStatus1);

            }
        }
        System.Console.WriteLine("Enter the BookingId");
        string id=Console.ReadLine();
        foreach(BookingDetail bookings in bookingList)
        {
            if(bookings.BookingId==id)
            {
                if(bookings.BookingStatus1==BookingStatus.Booked)
                {
                    foreach(OrderDetail orders in orderList)
                    {
                        System.Console.WriteLine(orders.OrderId+"\t"+orders.BookingId+"\t"+orders.ProductId+"\t"+orders.PurchaseCount+"\t"+orders.PriceOfOrder);

                    }
                }

            }
        }
        System.Console.WriteLine("Enter the OrderId");
        string orderID=Console.ReadLine();

        foreach(OrderDetail orders in orderList)
        {
            if(orders.OrderId==orderID)
            {
                System.Console.WriteLine("Enter the new Quantity of the product");
                int quantity=int.Parse(Console.ReadLine());

                foreach(ProductDetail products in productList)
                {
                    if(orders.ProductId==products.ProductId)
                    {
                         price=quantity*products.PricePerQuantity;

                    }
                }

                orders.PriceOfOrder=price;

               

            }
            
        }

    }
    public static void CancelOrder()
    {
       // System.Console.WriteLine("CancelOrder");
        //Show the booking list
        foreach(BookingDetail booking in bookingList)
        {
            
             if(CurrentCustomer.CustomerId==booking.CustomerId)
             {
                if(booking.BookingStatus1==BookingStatus.Booked)
                {
                    System.Console.WriteLine(booking.BookingId+"\t"+booking.CustomerId+"\t"+booking.TotalPrice+"\t"+booking.DateOfBooking+"\t"+booking.BookingStatus1);
                }
             }
        }
             System.Console.WriteLine("Enter the BookingId ");
             string id=Console.ReadLine();
             //Ask the user for bookingId 
             foreach(BookingDetail booking in bookingList)
             {
             if(booking.BookingId==id)
             {
                booking.BookingStatus1=BookingStatus.Cancelled;
                //Refund the balance to the currentcustomer
                CurrentCustomer.WalletBalance+=booking.TotalPrice;
                System.Console.WriteLine(CurrentCustomer.WalletBalance);
              
             }
             }
        
    }

    





}
