using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class View
    {
        int checkLogin = Const.LOGOUT;
        BookManagement book = new BookManagement();
        MemberManagement member = new MemberManagement();
        public void menu()
        {
            if (checkLogin == Const.MANAGER)
            {
                viewManager();
            }
            else if (checkLogin == Const.LOGIN)
            {
                viewLogin();
            }
            else
            {
                viewLogout();
            }
        }

        public void viewLogin()
        {
            Console.Clear();
            Console.WriteLine("< 도서 관리 프로그램 >\n");
            Console.WriteLine("1) 로그아웃");
            Console.WriteLine("2) 회원 정보 수정");
            Console.WriteLine("3) 회원 검색");
            Console.WriteLine("4) 회원 리스트 출력");
            Console.WriteLine("5) 도서 검색");
            Console.WriteLine("6) 도서 리스트 출력");
            Console.WriteLine("7) 도서 대여");
            Console.WriteLine("8) 도서 반납");
            Console.WriteLine("9) 회원 탈퇴");
            Console.WriteLine("10) 프로그램 종료");
            Console.Write("\n메뉴 번호를 선택해주세요 >> ");
            loginMode();
        }

        public void viewLogout()
        {
            Console.Clear();
            Console.WriteLine("< 도서 관리 프로그램 >\n");
            Console.WriteLine("1) 회원 가입");
            Console.WriteLine("2) 로그인");
            Console.WriteLine("3) 회원 검색");
            Console.WriteLine("4) 회원 리스트 출력");
            Console.WriteLine("5) 도서 검색");
            Console.WriteLine("6) 도서 리스트 출력");
            Console.WriteLine("7) 프로그램 종료");
            Console.Write("\n메뉴 번호를 선택해주세요 >> ");
            logoutMode();
        }

        public void viewManager()
        {
            Console.Clear();
            Console.WriteLine("< 도서 관리 프로그램 >");
            Console.WriteLine("관리자 모드\n");
            Console.WriteLine("1) 도서 등록");
            Console.WriteLine("2) 도서 검색");
            Console.WriteLine("3) 도서 리스트 출력");
            Console.WriteLine("4) 도서 변경");
            Console.WriteLine("5) 도서 삭제");
            Console.WriteLine("6) 회원 검색");
            Console.WriteLine("7) 회원 리스트 출력");
            Console.WriteLine("8) 관리자 모드에서 나가기");
            Console.WriteLine("9) 프로그램 종료");
            Console.Write("\n메뉴 번호를 선택해주세요 >> ");
            managerMode();
        }

        public void loginMode()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: checkLogin = Const.LOGOUT; menu(); break;
                case 2: member.modify(); viewLogin(); break;
                case 3: member.search(); viewLogin(); break;
                case 4: member.print(); viewLogin(); break;
                case 5: book.search(); viewLogin(); break;
                case 6: book.print(); viewLogin(); break;
                case 7: break;
                case 8: break;
                case 9: member.delete(); checkLogin = Const.LOGOUT; menu(); break;
                case 10: return;
                default: break;
            }
        }

        public void logoutMode()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: member.signUp(); viewLogout(); break;
                case 2: checkLogin = member.login(); menu(); break;
                case 3: member.search(); viewLogout(); break;
                case 4: member.print(); viewLogout(); break;
                case 5: book.search(); viewLogout(); break;
                case 6: book.print(); viewLogout(); break;
                case 7: return;
                default: break;
            }
        }

        public void managerMode()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: book.registration(); viewManager(); break;
                case 2: book.search(); viewManager(); break;
                case 3: book.print(); viewManager(); break;
                case 4: book.modify(); viewManager(); break;
                case 5: book.delete(); viewManager(); break;
                case 6: member.search(); viewManager(); break;
                case 7: member.print(); viewManager(); break;
                case 8: checkLogin = Const.LOGOUT; menu(); break;
                case 9: return;
                default: break;
            }
        }
    }
}
