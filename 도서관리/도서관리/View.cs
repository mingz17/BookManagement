using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class View
    {
        bool login = false;
        BookManagement book = new BookManagement();
        MemberManagement member = new MemberManagement();
        public void menu()
        {

            if ((login == Const.LOGIN))
            {
                viewLogin();

            }
            else
            {
                viewLogout();
            }

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
            Console.Write("\n메뉴 번호를 선택해주세요 >> ");
            managerMode();
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
            Console.WriteLine("7) 관리자 모드로 변경");
            Console.Write("\n메뉴 번호를 선택해주세요 >> ");
            logoutMode();
        }

        public void loginMode()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: book.search(); viewLogin(); break;
                case 6: book.print(); viewLogin(); break;
                case 7: break;
                case 8: break;
                case 9: break;
                default: break;
            }
        }

        public void logoutMode()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: book.search(); viewLogout(); break;
                case 6: book.print(); viewLogout(); break;
                case 7:
                    {
                        Console.Clear();
                        Input:
                        Console.Write("패스워드를 입력해주세요 (뒤로 돌아가려면 소문자로 return을 입력해주세요) >> ");
                        string manager = Console.ReadLine();
                        if (manager == "return")
                            viewLogout();
                        else if (manager == Const.MANAGER)
                            viewManager();
                        else
                        {
                            Console.WriteLine("비밀번호가 틀렸습니다.. 다시 입력해주세요\n");
                            goto Input;
                        }
                        break;
                    }
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
                case 6: break;
                case 7: break;
                case 8: viewLogout(); break;
                default: break;
            }
        }
    }
}
