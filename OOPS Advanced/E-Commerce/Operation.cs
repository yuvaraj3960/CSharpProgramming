using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce
{
    
    public class Operation
    {
      public  static List<OrderDetails> orderList=new List<OrderDetails>();
      public  static List<ProductDetails> productList=new List<ProductDetails>();
       public  static List<CustomerDetails> customerList=new List<CustomerDetails>();
        static CustomerDetails CurrentUser=null;
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("1.Registration 2.Login and Purchase 3.Exit");
                int option = int.Parse(Console.ReadLine());

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
                        Console.WriteLine("Login and Purchase");
                        Login();

                        break;
                    }
                    case 3:
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
            Console.WriteLine("Enter Your name");
            string customerName=Console.ReadLine();
            Console.WriteLine("Enter Your city");
            string city=Console.ReadLine();
            Console.WriteLine("Enter your phoneNumber");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your MailId");
            string mailId=Console.ReadLine();
            Console.WriteLine("Initial Balance");
            double initialBalance=double.Parse(Console.ReadLine());

            CustomerDetails  customer1=new CustomerDetails(customerName,city,phoneNumber,mailId,initialBalance);
            customerList.Add(customer1);

            Console.WriteLine("Your CustomerId is "+customer1.CustomerId);

        }
        public static  void Login()
        {
            Console.WriteLine("Enter Your customerId");
            string id = Console.ReadLine();

            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerId==id)
                {
                    CurrentUser=customer;
                    Console.WriteLine("Login Successfull");
                    SubMenu();

                }

            }
        }

        public static void SubMenu()
        {
            string choice1="yes";
            do{
                Console.WriteLine("1.Purchase 2.OrderHistory 3.CancelOrder 4.WalletBalance 5.Exit");
                int option1=int.Parse(Console.ReadLine());

                switch(option1)
                {
                    case 1:
                    {
                        Console.WriteLine("Purchase");
                        Purchase();

                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("OrderHistory");
                        

                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("CancelHistory");
                        CancelOrder();

                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("WalletBalance");
                        WalletBalance();

                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Exit SubMenu");
                        choice1="no";
    
                        break;
                    }
                }
            }while(choice1=="yes");
        }
       public void Default()
        {
            CustomerDetails customer2=new CustomerDetails("Ravi","chennai",9885858588,"ravi@mail.com",50000);
            CustomerDetails customer3=new CustomerDetails("Baskaran","chennai",9888475757,"baskaran@mail.com",60000);
            customerList.Add(customer2);
            customerList.Add(customer3);
            ProductDetails product1=new ProductDetails("Mobile",10,10000,3);
            productList.Add(product1);

            ProductDetails product2=new ProductDetails("Tablet",5,15000,2);
            productList.Add(product2);
             
            ProductDetails product3=new ProductDetails("Camera",3,20000,4);
            productList.Add(product3);

            ProductDetails product4=new ProductDetails("iPhone",5,50000,6);
            productList.Add(product4);
            ProductDetails product5=new ProductDetails("Laptop",3,40000,3);
            productList.Add(product5);

            OrderDetails order1=new OrderDetails(customer2.CustomerId,product1.ProductId,20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);

            OrderDetails order2=new OrderDetails(customer3.CustomerId,product3.ProductId,40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);





        }
        public static void Purchase()
        {
            foreach(ProductDetails products in productList)
            {
                Console.WriteLine(products.ProductId+"\t"+products.ProductName+"\t"+products.Price+"\t"+products.ShippingDuration);


            }  
            Console.WriteLine("Select any Product using ID");
            string product=Console.ReadLine();
            Console.WriteLine("Enter the Quantity");
            int quantity=int.Parse(Console.ReadLine());
            foreach(ProductDetails prod in productList)
            {
                if(product==prod.ProductId)
                {
                    if(quantity<=prod.AvalaibleStock)
                    {
                        double Amount=quantity*prod.Price+500;
                        WalletBalance();
                        if(CurrentUser.InitialBalance<Amount)
                        {
                            Console.WriteLine("insufficient balance");
                        }
                        
                        else
                        
                          {
                            CurrentUser.InitialBalance-=Amount;
                            prod.AvalaibleStock-=quantity;
                            foreach(OrderDetails order in orderList)
                            {
                            Console.WriteLine("Your OrderId is"+order.OrderId);
                            }
                            
  
                            
                            
                          }

                    }
                }
            }
            
        }
        public static void WalletBalance()
        {
            Console.WriteLine(CurrentUser.InitialBalance);
            Console.WriteLine("Do you wish to Recharge");
            string willing = Console.ReadLine().ToLower();
            if(willing=="yes")
            {
                Console.WriteLine("Enter the Amount to be Recharge");
                double amount=double.Parse(Console.ReadLine());

                CurrentUser.InitialBalance+=amount;
                Console.WriteLine(CurrentUser.InitialBalance);
            }
            else{
                Console.WriteLine("Go to SubMenu");
            }


        }
        public static void CancelOrder()
        {
            foreach(OrderDetails orders in orderList)
            {
                if(CurrentUser.CustomerId==orders.CustomerId)
                {
                    System.Console.WriteLine(orders.OrderId+"\t"+orders.CustomerId+"\t"+orders.ProductId+"\t"+orders.TotalPrice+"\t"+orders.PurchaseDate+"\t"+orders.QuantityPurchased+"\t"+orders.OrderStatus);
                }
            }
            System.Console.WriteLine("Enter the OrderId");
            string id=Console.ReadLine();
            foreach(OrderDetails orders in orderList)
            {
                if(id==orders.OrderId)
                {
                    foreach(ProductDetails products in productList)
                    {
                        if(orders.ProductId==products.ProductId)
                        {
                            products.AvalaibleStock+=orders.QuantityPurchased;
                            orders.QuantityPurchased=0;
                        }
                    }
                }

                if(CurrentUser.CustomerId==orders.CustomerId)
                {
                    CurrentUser.InitialBalance+=orders.TotalPrice;
                }

                orders.OrderStatus=OrderStatus.Cancelled;
            }
            System.Console.WriteLine("Cancelled Successfully");
        }

        public static void OrderHistory()
        {
            foreach(OrderDetails orders in orderList)
            {
                if(CurrentUser.CustomerId==orders.CustomerId)
                {
                    System.Console.WriteLine(orders.OrderId+"\t"+orders.CustomerId+"\t"+orders.ProductId+"\t"+orders.TotalPrice+"\t"+orders.PurchaseDate+"\t"+orders.QuantityPurchased+"\t"+orders.OrderStatus);
                }
            }
        }
    
        
        

        

    }
}
