using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission3
{
    public enum AdmissionProcess{Default,Admitted,cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;
        public string AdmissionId{get; set;}
        public string StudentId{get; set;}

        public string DepartmentId{get; set;}

        public DateTime AdmissionDate{get; set;}

        public AdmissionProcess AdmissionStatus{get; set;}


        public AdmissionDetails(string studentId,string departmentId,DateTime admissionDate,AdmissionProcess admissionStatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;

        }

        public AdmissionDetails(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,2));
            AdmissionId=values[0];
            AdmissionDate=DateTime.Parse(values[1]);
            AdmissionStatus=Enum.Parse<AdmissionProcess>(values[2]);

        }

        
 }

     
    }
