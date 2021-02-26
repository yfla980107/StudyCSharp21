using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrTest
{
    class AddressAll
    {
        public string name;
        public string phone;
        public string addr;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }

        public string Address
        {
            get { return addr; }
            set { this.addr = value; }
        }

        class Program
        {
            public static List<AddressAll> Mylist = new List<AddressAll>();

            public static void Startmenu()
            {
                
                    Console.WriteLine("---------------");
                    Console.WriteLine("0. 주소 입력");
                    Console.WriteLine("1. 검색");
                    Console.WriteLine("2. 수정");
                    Console.WriteLine("3. 삭제");
                    Console.WriteLine("4. 전체 출력");
                    Console.WriteLine("5. 프로그램 종료");
                    Console.WriteLine("---------------");
                
            }

            public static void Data_insert() //데이터 입력
            {
                string name, phone, addr;
                Console.Write("이름 입력: ");
                name = Console.ReadLine();
                Console.Write("전화 입력: ");
                phone = Console.ReadLine();
                Console.Write("주소 입력: ");
                addr = Console.ReadLine();

                AddressAll addressall = new AddressAll();
                addressall.name = name;
                addressall.phone = phone;
                addressall.addr = addr;
            }

            public static void Data_search() // 데이터 검색
            {
                string name;
                Console.WriteLine("이름 입력: ");
                name = Console.ReadLine();
            }

            static void Data_Delete() // 데이터 삭제
            {
                }
            }
            static void View() // 모든 데이터 
            {

            }

            static void Main(string[] args)
            {

                while (true)
                {
                    switch (key)
                    {
                        case "0":
                        Data_insert();
                            break;

                        case "1":
                            search();
                            break;

                        case "2":

                            break;

                        case "3":

                            break;

                        case "4":

                            break;
                        case "5":
                            Console.WriteLine("프로그램종료합니다.");
                            break;
                    }






                }
            }
        }
    }


