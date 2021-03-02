using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitCollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("배열을 통한 초기화");
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (var item in list)
            {
                Console.WriteLine($"Array : {item}");
            }

            Console.WriteLine("배열을 통한 스택 초기화");
            Stack stack = new Stack(arr);
            foreach (var item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }

            Console.WriteLine("컬렉션 초기자를 활용한 초기화");
            ArrayList list2 = new ArrayList() { 10, 20, 30, 40 };
            foreach (var item in list2)
            {
                Console.WriteLine($"ArrayList2 : {item}");
            }

        }
    }
}
