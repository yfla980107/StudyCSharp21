using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table 예제");

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";
            //ht의 key값이 일,이,삼,사 각각의 데이터를 One,Two, Three, Four 순으로 데이터 추가

            //1 일반 console로 출력시
            Console.WriteLine(ht["일"]); // "일"이라는 key를 쓰면 data인 One이 출력
            Console.WriteLine(ht["이"]);
            Console.WriteLine(ht["삼"]);
            Console.WriteLine(ht["사"]);

            //2 foreach문 사용 출력시
            //var에서 DictionaryEntry으로 변경
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}"); 
                //출력할때마다 값 순서가 계속 바뀜, 정렬을 하는 key값이 아님
            }


        }
    }
}
