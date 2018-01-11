using System;
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
            Console.Write("등록하려는 도서 이름을 입력하세요 >> ");
            string name = Console.ReadLine();
            Console.Write("등록하려는 도서의 저자를 입력하세요 >> ");
            string author = Console.ReadLine();
            Console.Write("등록하려는 도서의 가격을 입력하세요 >> ");
            string price = Console.ReadLine();

            book.Add(new BookVO(bookNum, name, author, price)); //new BookVO(){ BookNo = bookNo, BookName = bookName};
            Console.WriteLine("\n** 도서 등록이 완료되었습니다! **");
            System.Threading.Thread.Sleep(1500);
        }

        public void search()
        {
            Console.Clear();
            Console.Write("검색할 도서 이름을 입력하세요 >> ");
            //var obj = new BookVO();
            //obj.BookName = Console.ReadLine();
            string search = Console.ReadLine();

            if (book.Exists(x => x.BookName == search))
            {
                BookVO item = book.Find(x => x.BookName.Contains(search));
                Console.WriteLine("{0}  {1}  {2}  {3}원", item.BookNo, item.BookName, item.BookAuthor, item.BookPrice);
            }
            else
            {
                Console.WriteLine("도서를 찾을 수 없습니다..");
            }
            Console.Write("\n뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void print()
        {
            Console.Clear();
            foreach (BookVO item in book)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}원", item.BookNo, item.BookName, item.BookAuthor, item.BookPrice);
            }
            Console.Write("\n뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void modify()
        {
            Console.Clear();
            Console.Write("변경할 도서 이름을 입력하세요 >> ");
            string search = Console.ReadLine();
            BookVO item = book.Find(x => x.BookName.Contains(search));

            if (book.Exists(x => x.BookName == search))
            {
                Console.Write("\n변경된 도서 이름을 입력하세요 >> ");
                string name = Console.ReadLine();
                Console.Write("변경된 도서의 저자를 입력하세요 >> ");
                string author = Console.ReadLine();
                Console.Write("변경된 도서의 가격을 입력하세요 >> ");
                string price = Console.ReadLine();

                item.BookName = name;
                item.BookAuthor = author;
                item.BookPrice = price;

                Console.WriteLine("\n** 도서 변경이 완료되었습니다! **");
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("\n도서를 찾을 수 없습니다..");
                Console.Write("뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }

        }

        public void delete()
        {
            Console.Clear();
            Console.Write("삭제할 도서 이름을 입력하세요 >> ");
            string name = Console.ReadLine();
            Console.Write("삭제할 도서의 저자를 입력하세요 >> ");
            string author = Console.ReadLine();
            if (book.Exists(x => x.BookName == name && x.BookAuthor == author)) // 변수=book.Find(); if(변수!=null) 
            {
                book.Remove(book.Find(x => x.BookName.Contains(name) && x.BookAuthor.Contains(author)));
                int i = 1;
                foreach (BookVO item in book)
                {
                    item.BookNo = i++;
                }
                Console.WriteLine("\n** 도서 삭제가 완료되었습니다! **");
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("\n도서를 찾을 수 없습니다..");
                Console.Write("뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }

        }

    }
}
