using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("성명건", "010-6683-7732");

            if(PrintProfile(null, "010-1111-2222") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }

            // PrintProfile(phone: "010-9999-9999", name: "홍길동"); // 순서가 바뀌어도 자동으로 할당
            // PrintProfile(name: "홍길순", phone: "010-0000-0000"); //name, phone은 자동으로 지워줌, 쓸필요없음
            PrintProfile("최백호");
        }

        public static int PrintProfile(string name, string phone = "010-7979-7979")
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
