using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
namespace 도서관리
{
    class Exception
    {
        // foreach (Match match in Regex.Matches(input, pattern))
        /*
         * foreach (Match match in Regex.Matches(letter, @"[^a-zA-Z]{4,11}"))
                ismatch = match.Success;
        */
        public static bool CheckId(string letter) 
        {
            bool IsCheck = true;

            Regex engRegex = new Regex(@"[a-zA-Z]{4,11}");
            Boolean ismatch = engRegex.IsMatch(letter);
            Regex numRegex = new Regex(@"[0-9]");
            Boolean ismatchNum = numRegex.IsMatch(letter);

            if (!ismatch && !ismatchNum)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※영문<4~11자> 또는 숫자만 입력해주세요)");
                return IsCheck;
            }
            else
                return IsCheck;
        }

        public static bool CheckEnglishNumber(string letter)
        {
            bool IsCheck = true;

            Regex regex = new Regex(@"[a-z0-9_]{4,15}");
            Boolean ismatch = regex.IsMatch(letter);

            if (!ismatch)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※영문 또는 숫자만 입력해주세요<4~15자>)\n");
                return IsCheck;
            }
            else
                return IsCheck;
        }

        public static bool CheckEnglishKorean(string letter)
        {
            bool IsCheck = true;

            Regex engRegex = new Regex(@"[a-zA-Z]");
            Boolean ismatch = engRegex.IsMatch(letter);
            Regex korRegex = new Regex(@"[가-힣]");
            Boolean ismatchKor = korRegex.IsMatch(letter);

            if (!ismatch && !ismatchKor)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※한글 또는 영문만 입력해주세요)");
                return IsCheck;
            }
            else
                return IsCheck;
        }

        public static bool CheckName(string name)
        {
            bool IsCheck = true;

            Regex regex = new Regex(@"[가-힣]{2,5}");
            Boolean ismatch = regex.IsMatch(name);

            if (!ismatch)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※한글만 입력해주세요<2~5자>)");
                return IsCheck;
            }
            else
                return IsCheck;
        }

        public static bool CheckNumber(string letter)
        {
            bool IsCheck = true;

            Regex numRegex = new Regex(@"[0-9]");
            Boolean ismatch = numRegex.IsMatch(letter);

            if (!ismatch)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※숫자만 입력해주세요)");
                return IsCheck;
            }
            else
                return IsCheck;
        }

        public static bool CheckPhoneNumber(string num)
        {
            bool IsCheck = true;

            Regex numRegex = new Regex(@"010[0-9]{8}");
            Boolean ismatch = numRegex.IsMatch(num);

            if (!ismatch)
            {
                IsCheck = false;
            }

            if (!IsCheck)
            {
                Console.WriteLine("   (※숫자만 입력해주세요<11자리>)");
                return IsCheck;
            }
            else
                return IsCheck;
        }
    }
}
