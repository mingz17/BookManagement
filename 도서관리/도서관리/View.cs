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
            Console.WriteLine("도서 등록");
            Console.WriteLine("도서 검색");
            Console.WriteLine("도서 리스트 출력");
            Console.WriteLine("도서 변경");
            Console.WriteLine("도서 삭제");
            Console.WriteLine("회원 검색");
            Console.WriteLine("회원 리스트 출력");
            Console.WriteLine("관리자 모드에서 나가기");

            Console.Write("메뉴 번호를 선택해주세요 >> ");
            managerMode();
        }

        public void viewLogin()
        {
            Console.Clear();
            Console.WriteLine("< 도서 관리 프로그램 >");
            Console.WriteLine("로그아웃");
            Console.WriteLine("회원 정보 수정");
            Console.WriteLine("회원 검색");
            Console.WriteLine("회원 리스트 출력");
            Console.WriteLine("도서 검색");
            Console.WriteLine("도서 리스트 출력");
            Console.WriteLine("도서 대여");
            Console.WriteLine("도서 반납");
            Console.WriteLine("회원 탈퇴");

            Console.Write("메뉴 번호를 선택해주세요 >> ");
            loginMode();
        }

        public void viewLogout()
        {
            Console.Clear();
            Console.WriteLine("< 도서 관리 프로그램 >");
            Console.WriteLine("회원 가입");
            Console.WriteLine("로그인");
            Console.WriteLine("회원 검색");
            Console.WriteLine("회원 리스트 출력");
            Console.WriteLine("도서 검색");
            Console.WriteLine("도서 리스트 출력");
            Console.WriteLine("관리자 모드로 변경");
            Console.Write("메뉴 번호를 선택해주세요 >> ");
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
                case 5: break;
                case 6: break;
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
                case 5: break;
                case 6: break;
                case 7: {
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
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                case 8: viewLogout(); break;
                default: break;
            }
        }
    }
}
