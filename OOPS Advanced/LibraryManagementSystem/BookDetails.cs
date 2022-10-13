using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookDetails
    {
        public static int s_bookId=100;
        public string BookName{get;set;}
        public string AuthurName{get;set;}
        public int BookCount{get;set;}
        public string BookId{get;}

        public BookDetails(string bookName,string authurName,int bookCount)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthurName=authurName;
            BookCount=bookCount;
        }
    }
}