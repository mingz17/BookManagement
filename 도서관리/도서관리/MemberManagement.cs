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
        public MemberManagement()
        {
            member = new List<MemberVO>();
        }

        public void signUp()
        {
            Console.Clear();
            Console.Write("아이디를 입력하세요 >> ");
            string id = Console.ReadLine();
            Console.Write("패스워드를 입력하세요 >> ");
            string password = Console.ReadLine();
            Console.Write("가입하려는 회원 이름을 입력하세요 >> ");
            string name = Console.ReadLine();
            Console.Write("전화 번호를 입력하세요('-'제외) >> ");
            string phone = Console.ReadLine();

            member.Add(new MemberVO(id, password, name, phone));
            Console.WriteLine("\n** 회원 가입이 완료되었습니다! **");
            System.Threading.Thread.Sleep(1500);
        }

        public int login()
        {
            Console.Clear();
            Console.Write("아이디를 입력하세요 >> ");
            string id = Console.ReadLine();
            Console.Write("패스워드를 입력하세요 >> ");
            string password = Console.ReadLine();
            if (id == Const.MASTER && password == Const.MASTER)
            {
                return 0;
            }
            else if (member.Exists(x => x.Id == id && x.Password == password))
            {
                return 1;
            }
            else
            {
                Console.WriteLine("아이디 또는 패스워드가 틀렸습니다");
                Console.Write("\n뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
                return -1;
            }
        }

        public void search()
        {
            Console.Clear();
            Console.Write("검색할 회원의 이름을 입력하세요 >> ");
            string search = Console.ReadLine();

            if (member.Exists(x => x.MemberName == search)) // if(person==search)
            {
                MemberVO person = member.Find(x => x.MemberName.Contains(search));
                Console.WriteLine("{0}  {1}  {2}", person.Id, person.MemberName, person.MemberPhone);
            }
            else
            {
                Console.WriteLine("회원을 찾을 수 없습니다..");
            }
            Console.Write("\n뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void print()
        {
            Console.Clear();
            foreach (MemberVO person in member)
            {
                Console.WriteLine("{0}  {1}  {2}", person.Id, person.MemberName, person.MemberPhone);
            }
            Console.Write("\n뒤로 돌아가려면 아무 키나 누르세요..");
            Console.ReadKey();
        }

        public void modify()
        {
            Console.Clear();
            Console.Write("패스워드를 입력하세요 >> ");
            string search = Console.ReadLine();
            MemberVO person = member.Find(x => x.MemberName.Contains(search));

            if (member.Exists(x => x.Password == search))
            {
                Console.Write("\n변경된 회원 이름을 입력하세요 >> ");
                string name = Console.ReadLine();
                Console.Write("변경된 패스워드를 입력하세요 >> ");
                string password = Console.ReadLine();
                Console.Write("변경된 전화 번호를 입력하세요 >> ");
                string phone = Console.ReadLine();

                person.MemberName = name;
                person.Password = password;
                person.MemberPhone = phone;

                Console.WriteLine("\n** 회원 수정이 완료되었습니다! **");
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("\n비밀번호가 틀렸습니다..");
                Console.Write("뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }

        }

        public void delete()
        {
            Console.Clear();
            Console.Write("탈퇴할 회원 이름을 입력하세요 >> ");
            string name = Console.ReadLine();
            Console.Write("패스워드를 입력하세요 >> ");
            string password = Console.ReadLine();
            if (member.Exists(x => x.MemberName == name && x.Password == password)) // 변수=book.Find(); if(변수!=null) 
            {
                member.Remove(member.Find(x => x.MemberName.Contains(name) && x.Password.Contains(password)));
                Console.WriteLine("\n** 회원 탈퇴가 완료되었습니다! **");
                Console.WriteLine("   이용해주셔서 감사합니다 ღ•ᴗ•ღ ");
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("\n회원를 찾을 수 없습니다..");
                Console.Write("뒤로 돌아가려면 아무 키나 누르세요..");
                Console.ReadKey();
            }

        }
    }
}
