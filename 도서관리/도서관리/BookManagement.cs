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

        public void registration()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("\n   등록하려는 도서 이름을 입력하세요 ː ");
            string name = Console.ReadLine();

            InputAuthor:
            Console.Write("\n   등록하려는 도서의 저자를 입력하세요 ː ");
            string author = Console.ReadLine();
            if (!Exception.CheckEnglishKorean(author)) goto InputAuthor;
            if (book.Exists(x => x.BookName == name && x.BookAuthor == author))
            {
                Console.WriteLine("   이미 존재하는 도서입니다.");
                Console.Write("\n   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
                return;
            }

            InputPrice:
            Console.Write("\n   등록하려는 도서의 가격을 입력하세요 ː ");
            string price = Console.ReadLine();
            if (!Exception.CheckNumber(price)) goto InputPrice;

            int bookNum = book.Count();
            bookNum++;
            book.Add(new BookVO(bookNum, name, author, price, "○"));
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
                BookVO item = book.Find(x => x.BookName == search);
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
            BookVO item = book.Find(x => x.BookName == search);

            if (item != null)
            {
                Console.Write("\n   변경된 도서 이름을 입력하세요 ː ");
                string name = Console.ReadLine();
                InputAuthor:
                Console.Write("   변경된 도서의 저자를 입력하세요 ː ");
                string author = Console.ReadLine();
                if (!Exception.CheckEnglishKorean(author)) goto InputAuthor;
                InputPrice:
                Console.Write("   변경된 도서의 가격을 입력하세요 ː ");
                string price = Console.ReadLine();
                if (!Exception.CheckNumber(price)) goto InputPrice;

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

            InputAuthor:
            Console.Write("\n   삭제할 도서의 저자를 입력하세요 ː ");
            string author = Console.ReadLine();
            if (!Exception.CheckEnglishKorean(author)) goto InputAuthor;

            if (book.Exists(x => x.BookName == name && x.BookAuthor == author)) // remove=book.Find(); if(remove!=null) 
            {
                book.Remove(book.Find(x => x.BookName == name && x.BookAuthor == author));
                int number = 1;
                foreach (BookVO item in book)
                    item.BookNo = number++;

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

            Input:
            Console.Write("\n   대여할 도서의 번호를 선택하세요 ː ");
            string input = Console.ReadLine();
            if (!Exception.CheckNumber(input)) goto Input;
            int num = int.Parse(input);

            if (book.Exists(x => x.BookNo == num) && book.Find(x => x.BookNo == num).Lending == "○")
            {
                book.Find(x => x.BookNo == num).Lending = "Ｘ";
                string name = book.Find(x => x.BookNo == num).BookName;
                return name;
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
