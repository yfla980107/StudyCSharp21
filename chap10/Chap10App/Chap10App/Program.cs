using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Test
    { }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34}; //new int[5];
                                                 // var array = new int[];

            for (int i = 0; i < array.Length; i++) //for
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("크키 변경");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++) //for
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("81 인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >= idx; i--)
            {
                array[i] = array[i - 1];
                //Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            /* array[0] = 80;
             array[1] = 74;
             array[2] = 81;
             array[3] = 90;
             array[4] = 34;*/

            /*Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Type of array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++) //for
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");*/
        }

            /*  var idx = 0;
                foreach (var item in array) //foreach
                {
                   Console.WriteLine($"{idx++}번째 값 : {item}");
                }*/

            /*Console.WriteLine("오름차순 정렬");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++) //for
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순 정렬");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++) //for
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 34); // 배열 중 34인 값의 인덱스번호를 찾는 코드
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100); // 배열 중 100인 값
            Console.WriteLine($"100의 인덱스 : {idx}"); // 데이터가 없으면 -1 출력 

            Console.WriteLine("배열 삭제");
            Array.Clear(array, 3, 2); //3번째 인덱스부터 2자리를 삭제
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}"); // 그러므로 3,4인덱스가 삭제됨
            }*/

        }
    }

