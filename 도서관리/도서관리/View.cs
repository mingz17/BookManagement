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
            Console.WriteLine("\t\t《 도서 관리 프로그램 》\n");
            Console.WriteLine("\n\t⑴ 로그아웃");
            Console.WriteLine("\n\t⑵ 회원 정보 수정");
            Console.WriteLine("\n\t⑶ 회원 검색");
            Console.WriteLine("\n\t⑷ 회원 리스트 출력");
            Console.WriteLine("\n\t⑸ 도서 검색");
            Console.WriteLine("\n\t⑹ 도서 리스트 출력");
            Console.WriteLine("\n\t⑺ 도서 대여");
            Console.WriteLine("\n\t⑻ 도서 반납");
            Console.WriteLine("\n\t⑼ 회원 탈퇴");
            Console.WriteLine("\n\t⑽ 프로그램 종료");
            Console.Write("\n   메뉴 번호를 선택해주세요 ː ");
            loginMode();
        }

        public void viewLogout()
        {
            Console.Clear();
            Console.SetWindowSize(55, 20);
            Console.WriteLine("\t\t《 도서 관리 프로그램 》\n");
            Console.WriteLine("\n\t⑴ 회원 가입");
            Console.WriteLine("\n\t⑵ 로그인");
            Console.WriteLine("\n\t⑶ 회원 검색");
            Console.WriteLine("\n\t⑷ 회원 리스트 출력");
            Console.WriteLine("\n\t⑸ 도서 검색");
            Console.WriteLine("\n\t⑹ 도서 리스트 출력");
            Console.WriteLine("\n\t⑺ 프로그램 종료");
            Console.Write("\n   메뉴 번호를 선택해주세요 ː ");
            logoutMode();
        }

        public void viewManager()
        {
            Console.Clear();
            Console.SetWindowSize(55, 25);
            Console.WriteLine("\t\t《 도서 관리 프로그램 》\n");
            Console.WriteLine("\t\t    Θ관리자 모드Θ");
            Console.WriteLine("\n\t⑴ 도서 등록");
            Console.WriteLine("\n\t⑵ 도서 검색");
            Console.WriteLine("\n\t⑶ 도서 리스트 출력");
            Console.WriteLine("\n\t⑷ 도서 변경");
            Console.WriteLine("\n\t⑸ 도서 삭제");
            Console.WriteLine("\n\t⑹ 회원 검색");
            Console.WriteLine("\n\t⑺ 회원 리스트 출력");
            Console.WriteLine("\n\t⑻ 관리자 모드에서 나가기");
            Console.WriteLine("\n\t⑼ 프로그램 종료");
            Console.Write("\n   메뉴 번호를 선택해주세요 ː ");
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
