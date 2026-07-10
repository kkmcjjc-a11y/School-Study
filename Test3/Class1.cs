using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class Class1
    {
        //관리자 id, password 필드 만들고 생성자 만들고
        //id와 password를 확인하는 메서드 만들기
        //form1에서 class 객체를 만든 뒤 로그인하는 프로그램 만들기

        public string Id;
        public string Password;

        public Class1(string id, string password)
        {
            Id = id;
            Password = password;
        }

        public bool Login(string id, string password)
        {
            if (Id == id && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
