using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrTest
{
    class Address1
    {
        public string name, phone, addr;
        public void 입력()
        {
            this.name = Console.ReadLine();
            this.phone = Console.ReadLine();
            this.addr = Console.ReadLine();
            
            Console.WriteLine($"-------{}-------"
                              , "이름 : {this.name}"
                              , "전화 : {this.phone}"
                              , "주소 : {this.addr}");
        }
    }
    class Program
        {
            static void Main(string[] args)
            {

            Address1 address = new Address1();

              Console.WriteLine("-------------"
                                 , "0. 주소 입력"
                                 , "1. 주소 검색"
                                 , "2. 주소 수정"
                                 , "3. 주소 삭제"
                                 , "4. 주소 전체 출력"
                                 , "5. 프로그램 종료");
            }

    }
    
}
