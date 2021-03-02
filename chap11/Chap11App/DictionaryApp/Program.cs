﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        // 실무에서 많이 쓰는 컬렉션 2
        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>() //정수형, 문자열
            { { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" } , };
            //== 똑같은 방법
            /*pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";*/

            foreach (var item in pairs) //해시테이블과 다르게 순서대로 나옴
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>(); //문자열,문자열
            /*pairs2["일"] = "One";
            pairs2["이"] = "Two";
            pairs2["삼"] = "Three";
            pairs2["사"] = "Four";
            pairs2["오"] = "Five";*/
            
            foreach (var item in pairs2) //해시테이블과 다르게 순서대로 나옴
            {
                Console.WriteLine(item);
            }
        }
    }
}
