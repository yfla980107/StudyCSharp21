using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열 추가 방법1
            /*array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/

            //배열 추가 방법2
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34 });

            var loc = array.IndexOf(81); //81데이터가 들어간 인덱스 찾기
            array.Insert(loc, 50); //81인 들어간 인덱스 2번에 50 삽입

            Console.WriteLine("81위치에 50 추가");
            foreach (var item in array) //foreach문을 통해 배열 출력
            {
                Console.WriteLine($" {item} ");
            }

            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);
            array.RemoveAt(4);

            foreach (var item in array)
            {
                Console.WriteLine($" {item} ");

            }

            Console.WriteLine("정렬");
            array.Sort(); //정렬 함수
            foreach (var item in array)
            {
                Console.WriteLine($" {item} ");
            }

            }
        }
    }

