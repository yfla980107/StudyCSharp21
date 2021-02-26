using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrTest
{
    public class AddressAll
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

            public static string selectMenu()
            {
                string s;
                Console.WriteLine("---------------");
                Console.WriteLine("0. 주소 입력");
                Console.WriteLine("1. 검색");
                Console.WriteLine("2. 수정");
                Console.WriteLine("3. 삭제");
                Console.WriteLine("4 전체 출력");
                Console.WriteLine("5. 프로그램 종료");
                Console.WriteLine("---------------");
                s = Console.ReadLine();
                return s;

            }
            static public void insert()
            {
                string name, phone, addr;
                Console.Write("이름 입력: ");
                name = Console.ReadLine();
                Console.Write("전화 입력: ");
                phone = Console.ReadLine();
                Console.Write("주소 입력: ");
                addr = Console.ReadLine();
                AddressAll person = new AddressAll();
                Mylist.Add(person);
            }

            static public void search()
            {
                string name;
                Console.WriteLine("이름 입력: ");
                name = Console.ReadLine();
            }

            static void Delete()
            {
                string del;

                del = Console.ReadLine();

                for (int i = 0; i < Mylist.Count; ++i)
                {
                    if (del == Mylist[i].Name)
                    {
                        Mylist.Remove[i];
                    }
                }
            }
            static void View()
            {
                for(int i=0; i < Mylist.Count; ++i)
                {
                    Console.WriteLine($"------------0---------\n" +\ $"이름:{Mylist[i].name()}, 전화번호:{MyList[i].phone()}, 주소:{MyList[i].addr()}}");
                }
            }




            static void Main(string[] args)
            {
                string key;

                while ((key = selectMenu()) != "5") break;
                {
                    switch (key)
                    {
                        case "0":
                            insert();
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
}

