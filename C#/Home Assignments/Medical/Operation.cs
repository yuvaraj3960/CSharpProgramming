using System;

using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public class Operation

    {
        public static List<MedicineDetail> medicineList=new List<MedicineDetail>();

        public static List<OrderDetail> orderList=new List<OrderDetail>();
        public static UserDetail CurrentUser=null;
        public static List<UserDetail> userList=new List<UserDetail>();
        public static void MainMenu()
        {
            string condition="yes";
            do{
                
                
        System.Console.WriteLine("1.UserRegistration 2.Login 3.orderDetails 4.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
            Console.WriteLine("Registration process");
            UserRegistration();
             
                break;
            }
            case 2:
            {
                Console.WriteLine("Login Process");
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
        System.Console.WriteLine("do you want to continue");
        condition=Console.ReadLine();
        }while(condition=="yes");
        }
        public static void UserRegistration()
        {

         System.Console.WriteLine("Enter your name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your age");
        int age= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your city");
        string city=Console.ReadLine();
        System.Console.WriteLine("Enter your phonenumber");
        long phoneNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the balance");
        double balance=double.Parse(Console.ReadLine());
        UserDetail user3=new UserDetail(name,age,city,phoneNumber,balance);
        userList.Add(user3);
        System.Console.WriteLine("Your UserId is "+user3.UserId);

        }

        public static void Login()
        {
            string condition="yes";
            do{
                
            Console.WriteLine("Enter your UserID");
            string id = Console.ReadLine();

             foreach(UserDetail user in userList)
             {
                if(user.UserId==id)
                {
                    System.Console.WriteLine("Login Successful");
                    CurrentUser=user;
                    SubMenu();

                }
               /* else
                {
                    System.Console.WriteLine("Invalid userId");
                }
                System.Console.WriteLine("Do want to try again");
                condition=Console.ReadLine().ToLower();*/
             }
            }while(condition=="yes");

            
            
        }

        public static void SubMenu()
        {
            string condition="yes";
            do{
            System.Console.WriteLine("1.ShowMedicine List 2.Purchase 3.Cancel 4.Wallet 5.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Showing Medicine List");
                    ShowMedicine();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Purchase Your Medicines");
                    Purchase();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Cancel Medicine");
                    CancelPurchase();
                    break;
                }
                case 4:
                {
                    ShowPurchaseHistory();
                    break;
                }
             
           
                
                case 5:
                {
                    System.Console.WriteLine("Recharge");
                    Recharge();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exit SubMenu");
                    condition="no";
                    break;
                }
            }
         
            }while(condition=="yes");
        }



        public static void ShowMedicine()
        {
            foreach(MedicineDetail med in medicineList)
            {
                System.Console.WriteLine(med.MedicineId+"\t"+med.MedicineName+"\t"+med.AvailableCount+"\t"+med.Price+"\t"+med.DateOfExpiry+"\t");

            }

        }

        public static void Purchase()
        {
            ShowMedicine();
            //Show the medicine list by travesing the list
            
            //Ask the user which med wants to buy
            Console.WriteLine("Enter the medicineID you want to buy");
            string medid=Console.ReadLine();

            
                 //Ask the no of count he wants to buy
                System.Console.WriteLine("Enter the count want to buy");
                int count=int.Parse(Console.ReadLine());

            foreach(MedicineDetail med in medicineList)
            {
               // System.Console.WriteLine(med.MedicineId+"\t"+med.MedicineName+"\t"+med.AvailableCount+"\t"+med.Price+"\t"+med.DateOfExpiry+"\t");

            


            if(medid==med.MedicineId)
            {
                
            //check the med , count and wallet for the purchase and med Expiry date
                 
                 if(med.AvailableCount>=count)

                 {
                    if(CurrentUser.Balance>=med.Price)
                        {
                            if(DateTime.Now<med.DateOfExpiry)
                            {
                                double TotalPrice=count*med.Price;
                                System.Console.WriteLine("Total Price "+TotalPrice);
                                
            

                                OrderDetail order1=new OrderDetail(CurrentUser.UserId,med.MedicineId,count,TotalPrice,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(order1);
                                System.Console.WriteLine("OrderId"+order1.OrderId);
                            
                                med.AvailableCount-=count;

                             CurrentUser.Balance-=count*med.Price;
                             System.Console.WriteLine("Medicine Successfully purchased");

                                

                                
                                
                            }
                        }
                    
                    

                 }
            }
                 
            
           
            
            

            





            
            } 
            
        }

        public static void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge");
            double amount=double.Parse(Console.ReadLine());

        foreach(UserDetail user in userList)
        {
            user.Balance+=amount;
        }

        }

        public static void CancelPurchase()
        {
            foreach(OrderDetail user in orderList)
            {
                if(CurrentUser.UserId==user.UserId)
                {
                    System.Console.WriteLine(user.OrderId+"\t"+user.UserId+"\t"+user.MedicineId+"\t"+user.MedicineCount+"t"+user.TotalPrice+"\t"+user.OrderDate+"\t"+user.OrderStatus);
                     System.Console.WriteLine("Enter your OrderId");
                     string id=Console.ReadLine();
                     if(user.OrderId==id)
                     {
                        if(user.OrderStatus==OrderStatus.Purchased)

                        {
                            System.Console.WriteLine("Enter the count for Cancelling ");
                            int count=int.Parse(Console.ReadLine());
                            foreach(MedicineDetail med in medicineList)
                            {
                                med.AvailableCount+=count;
                                if(user.MedicineId==med.MedicineId)
                                {
                                    double pricecal=count*med.Price;
                                    CurrentUser.Balance+=pricecal;
                                    double cost=user.TotalPrice-pricecal;
                                    int counts=user.MedicineCount-count;
                                    DateTime date=DateTime.Now;
                                    user.OrderStatus=OrderStatus.Cancelled;
                                    OrderDetail users1=new OrderDetail(CurrentUser.UserId,user.MedicineId,counts,cost,date,user.OrderStatus);
                                    System.Console.WriteLine("Your Id"+user.OrderId+" was successfully cancelled");

                    

                                }
                                
                            }

                        }
                     }
                }
                
                    
                
                
        
                
                
                    
                
                
                    
                
            }
        }
        public static void ShowPurchaseHistory()
        {
            foreach(OrderDetail user in orderList)
            {
                if(CurrentUser.UserId==user.OrderId)
                {
                    System.Console.WriteLine(user.OrderId+"\t"+user.UserId+"\t"+user.MedicineId+"\t"+user.MedicineCount+"\t"+user.TotalPrice+"\t"+user.OrderDate+"\t"+user.OrderStatus);

                }
            }
            
            
            
            
        }
        

    }
}