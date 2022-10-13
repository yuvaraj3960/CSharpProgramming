using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    
    public class Operation
    {
        static List<FoodDetail> foodList=new List<FoodDetail>();
        static List<CustomerRegistration> customerList=new List<CustomerRegistration>();
        static List<BookingDetail> bookingList=new List<BookingDetail>();
        static List<OrderDetail> orderList=new List<OrderDetail>();
        public static void DefaultValues()
        {
            //CustomerDetails
            CustomerRegistration customer1 =new CustomerRegistration("Ravi","Ettaparajan",Gender.Male,98765432,new DateTime(1999,11,11),"ravi@gmail.com","Chennai");
            customerList.Add(customer1);
            CustomerRegistration customer2 =new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,87655432,new DateTime(1999,11,11),"basakaran@gmail.com","Chennai");
            customerList.Add(customer2);

            //FoodDetails
            FoodDetail food1 =new FoodDetail("Chicken Biriyani",100);
            foodList.Add(food1);
            FoodDetail food2 = new FoodDetail("Mutton Biriyani",150);
            foodList.Add(food2);
            FoodDetail food3=  new FoodDetail("Rice",80);
            foodList.Add(food3);

            FoodDetail food4=  new FoodDetail("Noodles",100);
            foodList.Add(food4);
            FoodDetail food5=  new FoodDetail("Dosa",40);
            foodList.Add(food5);
            FoodDetail food6=  new FoodDetail("Idly",20);
            foodList.Add(food6);
            FoodDetail food7=  new FoodDetail("Pongal",60);
            foodList.Add(food7);
            FoodDetail food8=  new FoodDetail("Vegetable Biriyani",80);
            foodList.Add(food8);
            FoodDetail food9=  new FoodDetail("Lemon RFice",50);
            foodList.Add(food9);
            FoodDetail food10=  new FoodDetail("Veg Pulav",120);
            foodList.Add(food10);

            //Booking Detail

            BookingDetail booking1=new BookingDetail(customer1.CustomerId,580,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(booking1);
            BookingDetail booking2=new BookingDetail(customer2.CustomerId,870,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(booking2);
            BookingDetail booking3=new BookingDetail(customer1.CustomerId,820,new DateTime(2022,07,26),BookingStatus.Cancelled);
            bookingList.Add(booking3);


            //OrderDetail

            OrderDetail order1=new OrderDetail(booking1.BookingId,food1.FoodId,2,200);
            orderList.Add(order1);
            OrderDetail order2=new OrderDetail(booking1.BookingId,food2.FoodId,2,300);
            orderList
            OrderDetail order3=new OrderDetail(booking1.BookingId,food3.FoodId,1,80);
            OrderDetail order4=new OrderDetail(booking2.BookingId,food1.FoodId,1,100);
            OrderDetail order5=new OrderDetail(booking2.BookingId,food2.FoodId,4,600);
            OrderDetail order6=new OrderDetail(booking2.BookingId,food10.FoodId,1,120);
            OrderDetail order7=new OrderDetail(booking2.BookingId,food9.FoodId,1,50);
            OrderDetail order8=new OrderDetail(booking3.BookingId,food2.FoodId,2,500);
            OrderDetail order9=new OrderDetail(booking3.BookingId,food8.FoodId,4,320);
            OrderDetail order10=new OrderDetail(booking3.BookingId,food1.FoodId,2,200);

    }

    public static void ShowFoodDetail()
    {
        foreach()
    }
    }
}