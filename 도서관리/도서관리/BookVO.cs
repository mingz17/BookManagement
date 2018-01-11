using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class BookVO
    {
        private int bookNo;
        private string bookName;
        private string bookAuthor;
        private string bookPrice;


        public BookVO() { }
        public BookVO(int bookNo, string bookName, string bookAuthor, string bookPrice)
        {
            this.bookNo = bookNo;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
        }

        public int BookNo //get; set;
        {
            get { return bookNo; }
            set { bookNo = value; }
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public string BookPrice
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }
    }
}
