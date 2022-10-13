using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public class MedicineDetail
    {
        private static int s_medicineId=100;
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price{get;set;}
        public string MedicineId{get;set;}
        public DateTime DateOfExpiry{get;set;}

        public MedicineDetail(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineId="MD"+s_medicineId;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

        public MedicineDetail(string data)
        {
            string[] values=data.Split(",");
            s_medicineId=int.Parse(values[0].Remove(0,2));
            MedicineId=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price=double.Parse(values[3]);
            DateOfExpiry=DateTime.Parse(values[4]);
        }

        
    }
}