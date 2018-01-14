using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서관리
{
    class MemberVO
    {
        private string id;
        private string password;
        private string memberName;
        private string memberPhone;
        private List<string> lendBook;
        private List<string> returnDate;

        public MemberVO(string id, string password, string memberName, string memberPhone, List<string> lendBook, List<string> returnDate)
        {
            this.id = id;
            this.password = password;
            this.memberName = memberName;
            this.memberPhone = memberPhone;
            this.lendBook = lendBook;
            this.returnDate = returnDate;
        }

        public string Id
        {
            get { return id; }
            set { Id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string MemberPhone
        {
            get { return memberPhone; }
            set { memberPhone = value; }
        }

        public List<string> LendBook
        {
            get { return lendBook; }
            set { lendBook = value; }
        }

        public List<string> ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
    }
}

