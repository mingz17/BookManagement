using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class MemberManagement
    {
        List<MemberVO> member;
        MemberVO memberLogin;
        public MemberManagement()
        {
            member = new List<MemberVO>();
        }

        public void signUp()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("\n   아이디를 입력하세요 ː ");
            string id = Console.ReadLine();
            Console.Write("\n   패스워드를 입력하세요 ː ");
            string password = Console.ReadLine();
            Console.Write("\n   가입하려는 회원 이름을 입력하세요 ː ");
            string name = Console.ReadLine();
            Console.Write("\n   전화 번호를 입력하세요('-'제외) ː ");
            string phone = Console.ReadLine();

            member.Add(new MemberVO(id, password, name, phone, new List<string>(), new List<string>()));
            Console.WriteLine("\n\t\t『 회원 가입이 완료되었습니다 』");
            System.Threading.Thread.Sleep(1300);
        }

        public int login()
        {
            Console.Clear();
            Console.SetWindowSize(50, 15);
            Console.Write("\n\n   아이디를 입력하세요 ː ");
            string id = Console.ReadLine();
            Console.Write("   패스워드를 입력하세요 ː ");
            string password = Console.ReadLine();

            if (id == Const.MASTER && password == Const.MASTER)
            {
                return 0;
            }
            else if (member.Exists(x => x.Id == id && x.Password == password))
            {
                memberLogin = member.Find(x => x.Id == id && x.Password == password);
                return 1;
            }
            else
            {
                Console.WriteLine("\n   아이디 또는 패스워드가 틀렸습니다");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
                return -1;
            }
        }

        public void search()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.Write("   검색할 회원의 이름을 입력하세요 ː ");
            string search = Console.ReadLine();


            if (member.Exists(x => x.MemberName == search)) // if(person==search)
            {
                Console.WriteLine("\n\t\t아이디\t  회원 이름 \t 전화 번호");
                MemberVO person = member.Find(x => x.MemberName == search);
                Console.WriteLine("\n\t\t {0} \t  {1} \t{2}", person.Id, person.MemberName, person.MemberPhone);
            }
            else
            {
                Console.WriteLine("   회원을 찾을 수 없습니다..");
            }
            Console.Write("\n   뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void print()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.WriteLine("\t\t아이디\t  회원 이름 \t 전화 번호");
            foreach (MemberVO person in member)
            {
                Console.WriteLine("\n\t\t {0} \t  {1} \t{2}", person.Id, person.MemberName, person.MemberPhone);
            }
            Console.Write("\n   뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void modify()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("   패스워드를 입력하세요 ː ");
            string search = Console.ReadLine();
            MemberVO person = member.Find(x => x.MemberName == search);

            if (memberLogin.Password == search) //member.Exists(x => x.Password == search )
            {
                Console.Write("\n   변경된 회원 이름을 입력하세요 ː ");
                string name = Console.ReadLine();
                Console.Write("   변경된 패스워드를 입력하세요 ː ");
                string password = Console.ReadLine();
                Console.Write("   변경된 전화 번호를 입력하세요 ː ");
                string phone = Console.ReadLine();

                person.MemberName = name;
                person.Password = password;
                person.MemberPhone = phone;

                Console.WriteLine("\n\t\t『 회원 수정이 완료되었습니다 』");
                System.Threading.Thread.Sleep(1300);
            }
            else
            {
                Console.WriteLine("\n   비밀번호가 틀렸습니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }
        }

        public void delete()
        {
            Console.Clear();
            Console.SetWindowSize(65, 15);
            Console.Write("\n   탈퇴할 회원 이름을 입력하세요 ː ");
            string name = Console.ReadLine();
            Console.Write("\n   패스워드를 입력하세요 ː ");
            string password = Console.ReadLine();
            if (memberLogin.MemberName == name && memberLogin.Password == password) // 변수=book.Find(); if(변수!=null) member.Exists(x => x.MemberName == name && x.Password == password)
            {
                member.Remove(member.Find(x => x.MemberName == name && x.Password == password));
                Console.WriteLine("\n\t\t『 회원 탈퇴가 완료되었습니다 』");
                Console.WriteLine("\n\t\t ♥ 이용해주셔서 감사합니다 ♥");
                System.Threading.Thread.Sleep(1300);
            }
            else
            {
                Console.WriteLine("\n   회원를 찾을 수 없습니다..");
                Console.Write("   뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }
        }

        DateTime now; //DateTime.Now.ToShortDateString()
        //int bookLendingNum = 0;
        public void bookLending(string bookName)
        {
            //int num = memberLogin.LendBook.Count;
            //List<string> tmp = new List<string>();
            //tmp[num] = bookName;
            now = DateTime.Now.AddDays(14);
            memberLogin.ReturnDate.Add(now.ToShortDateString());
            memberLogin.LendBook.Add(bookName);
            Console.WriteLine("\n\t\t『 대여가 완료되었습니다 』");
            System.Threading.Thread.Sleep(1300);
        }

        public string bookReturning()
        {
            Console.Clear();
            Console.SetWindowSize(70, 15);
            Console.WriteLine("\t\t\t《 대여한 도서 》");
            int count = 1,returnNum=0;
            now = DateTime.Now.AddDays(14);
            Console.WriteLine("\t\t번호\t 책 이름 \t반납 기한");
            foreach (string item in memberLogin.LendBook)
            {
                Console.WriteLine("\n\t\t{0}\t{1}\t{2}", count++, item,memberLogin.ReturnDate[returnNum]);
            }
            Console.Write("\n   반납할 도서의 번호를 선택하세요 ː ");
            int num = int.Parse(Console.ReadLine());

            if (num <= memberLogin.LendBook.Count&&num>0)
            {
                string name = memberLogin.LendBook[--num];
                memberLogin.LendBook.RemoveAt(num);
                memberLogin.ReturnDate.RemoveAt(num);
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
    }
}
