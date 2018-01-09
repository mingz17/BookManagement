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

        public MemberVO(string id, string password, string memberName, string memberPhone)
        {
            this.id = id;
            this.password = password;
            this.memberName = memberName;
            this.memberPhone = memberPhone;
        }

        public int Id
        {
            get { return Id; }
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
    }
}

