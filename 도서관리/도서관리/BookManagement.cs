﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class BookManagement
    {
        List<BookVO> book;

        public BookManagement()
        {
            book = new List<BookVO>();
        }

        public void registration()//매개변수 int bookNo, string bookName, string bookAuthor, string bookPrice)
        {
            int bookNum = book.Count();
            bookNum++;
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("\n   등록하려는 도서 이름을 입력하세요 ː ");
            string name = Console.ReadLine();
            Console.Write("\n   등록하려는 도서의 저자를 입력하세요 ː ");
            string author = Console.ReadLine();
            Console.Write("\n   등록하려는 도서의 가격을 입력하세요 ː ");
            string price = Console.ReadLine();

            book.Add(new BookVO(bookNum, name, author, price, "○")); //new BookVO(){ BookNo = bookNo, BookName = bookName};
            Console.WriteLine("\n\t\t『 도서 등록이 완료되었습니다 』");
            System.Threading.Thread.Sleep(1300);
        }

        public void search()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.Write("   검색할 도서 이름을 입력하세요 ː ");
            string search = Console.ReadLine();

            if (book.Exists(x => x.BookName == search))
            {
                Console.WriteLine("\n\t번호\t  책 이름 \t 저자 \t   가격");
                BookVO item = book.Find(x => x.BookName==search);
                Console.WriteLine("\n\t  {0}\t {1}\t{2}\t  {3}원", item.BookNo, item.BookName, item.BookAuthor, item.BookPrice);
            }
            else
            {
                Console.WriteLine("   도서를 찾을 수 없습니다..");
            }
            Console.Write("\n   뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void print()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.WriteLine("\t번호\t  책 이름 \t 저자 \t   가격\t\t대여가능");
            foreach (BookVO item in book)
            {
                Console.WriteLine("\n\t  {0}\t {1}\t{2}\t  {3}원\t  {4}", item.BookNo, item.BookName, item.BookAuthor, item.BookPrice, item.Lending);
            }
            Console.Write("\n   뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void modify()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("   변경할 도서 이름을 입력하세요 ː ");
            string search = Console.ReadLine();
            BookVO item = book.Find(x => x.BookName==search);

            if (book.Exists(x => x.BookName == search))
            {
                Console.Write("\n   변경된 도서 이름을 입력하세요 ː ");
                string name = Console.ReadLine();
                Console.Write("   변경된 도서의 저자를 입력하세요 ː ");
                string author = Console.ReadLine();
                Console.Write("   변경된 도서의 가격을 입력하세요 ː ");
                string price = Console.ReadLine();

                item.BookName = name;
                item.BookAuthor = author;
                item.BookPrice = price;

                Console.WriteLine("\n\t\t『 도서 변경이 완료되었습니다 』");
                System.Threading.Thread.Sleep(1300);
            }
            else
            {
                Console.WriteLine("\n   도서를 찾을 수 없습니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }

        }

        public void delete()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("\n   삭제할 도서 이름을 입력하세요 ː ");
            string name = Console.ReadLine();
            Console.Write("\n   삭제할 도서의 저자를 입력하세요 ː ");
            string author = Console.ReadLine();
            if (book.Exists(x => x.BookName == name && x.BookAuthor == author)) // 변수=book.Find(); if(변수!=null) 
            {
                book.Remove(book.Find(x => x.BookName==name && x.BookAuthor==author));
                int i = 1;
                foreach (BookVO item in book)
                {
                    item.BookNo = i++;
                }
                Console.WriteLine("\n\t\t『 도서 삭제가 완료되었습니다 』");
                System.Threading.Thread.Sleep(1300);
            }
            else
            {
                Console.WriteLine("\n   도서를 찾을 수 없습니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }
        }

        public string bookLending()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.WriteLine("\t번호\t  책 이름 \t 저자 \t   가격\t\t대여가능");
            foreach (BookVO item in book)
            {
                Console.WriteLine("\n\t  {0}\t {1}\t{2}\t  {3}원\t  {4}", item.BookNo, item.BookName, item.BookAuthor, item.BookPrice, item.Lending);
            }
            Console.Write("\n   대여할 도서의 번호를 선택하세요 ː ");
            int num = int.Parse(Console.ReadLine());

            
            if (book.Exists(x => x.BookNo == num)&&book.Find(x => x.BookNo == num).Lending == "○")
            {
                book.Find(x => x.BookNo == num).Lending = "Ｘ";
                string name = book.Find(x => x.BookNo == num).BookName;
                return name;
            }
            else if (book.Find(x => x.BookNo == num).Lending == "X")
            {
                Console.WriteLine("\n   대여할 수 없는 도서입니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
                return null;
            }
            else
            {
                Console.WriteLine("\n   해당하는 도서가 없습니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
                return null;
            }
        }

        public void bookReturning(string bookName)
        {
            book.Find(x => x.BookName == bookName).Lending = "○";
            Console.WriteLine("\n\t\t『 반납이 완료되었습니다 』");
            System.Threading.Thread.Sleep(1300);
        }

    }
}
