using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Medical
{
    public class Files
    {
        public static void Create()
        {
        if(!Directory.Exists("Medical"))
        {
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("Medical");
        }
        if(!File.Exists("Medical/UserDetails.csv"))
        {
            System.Console.WriteLine("Creating File");
            File.Create("Medical/UserDetails.csv");
        }
        if(!File.Exists("Medical/MedicineDetail.csv"))
        {
            System.Console.WriteLine("Creating File");
            File.Create("Medical/MedicineDetail.csv");
        }
        if(!File.Exists("Medical/OrderDetail.csv"))
        {
            System.Console.WriteLine("Creating File");
            File.Create("Medical/OrderDetail.csv");
        }

        }

        public static void ReadFiles()
        {
            string[] user=File.ReadAllLines("Medical/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetail users = new UserDetail(data);
                Operation.userList.Add(users);

            }
            string[] med=File.ReadAllLines("Medical/MedicineDetail.csv");
            foreach(string data in med)
            {
                MedicineDetail medicine= new MedicineDetail(data);
                Operation.medicineList.Add(medicine);
            }
            string[] order=File.ReadAllLines("Medical/OrderDetail.csv");
            foreach(string data in order)
            {
                OrderDetail orders=new OrderDetail(data);
                Operation.orderList.Add(orders);
            }

        }

        public static void WriteFiles()
        {
            string [] users=new string[Operation.userList.Count];
            for (int i=0;i<Operation.userList.Count;i++)
            {
                users[i]=Operation.userList[i].UserId+','+Operation.userList[i].UserName+','+Operation.userList[i].Age+','+Operation.userList[i].City+','+Operation.userList[i].PhoneNumber+Operation.userList[i].Balance;
            }
            File.WriteAllLines("Medical/UserDetails.csv",users);

            string[] medical=new string[Operation.medicineList.Count];
            for(int i=0;i<Operation.medicineList.Count;i++)
            {
                medical[i]=Operation.medicineList[i].MedicineId+','+Operation.medicineList[i].MedicineName+','+Operation.medicineList[i].AvailableCount+','+Operation.medicineList[i].Price+','+Operation.medicineList[i].DateOfExpiry;

            }
            File.WriteAllLines("Medical/MedicineDetail.csv",medical);

            string[] order=new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderId+','+Operation.orderList[i].UserId+','+Operation.orderList[i].MedicineId+','+Operation.orderList[i].MedicineCount+','+Operation.orderList[i].TotalPrice+','+Operation.orderList[i].OrderDate+','+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Medical/OrderDetail.csv",order);
        }
        
    }
}