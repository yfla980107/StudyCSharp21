using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < 5; i++) // 문법적 오류가 아니라 컴파일에서는 에러가 안남 == 예외
            {
                Console.WriteLine($"{i}번째 값 : {arr[i]}");
            }
        }
    }
}
