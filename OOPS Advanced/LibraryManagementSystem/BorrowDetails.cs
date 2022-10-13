using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum Status{Default,Issued,Returned}
    public class BorrowDetails
    {
        
        private static int s_borrowId=300;
        public String BookId{get;set;}
        public string RegisterNumber{get;}
        public DateTime BorrowDate{get;set;}
        public Status Status{get;set;}
        public String BorrowId{get;}

        public BorrowDetails(string bookId,string registerNumber,DateTime borrowDate,Status status)
        {
            s_borrowId++;
            BorrowId="LB"+s_borrowId;
            BookId=bookId;
            RegisterNumber=registerNumber;
            BorrowDate=borrowDate;
            Status=status;
        }
        
    }
}