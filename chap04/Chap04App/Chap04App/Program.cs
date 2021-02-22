using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 == 0) // 짝수 홀수 알아보기
            {
                Console.WriteLine("짝수입니다");

            }
            else
            {
                Console.WriteLine("홀수입니다");
            }

            if (values % 3 == 0) // 3의 배수 알아보기
            {
                Console.WriteLine("3의 배수입니다");

            }
            else
            {
                Console.WriteLine("3의 배수가 아닙니다");
            }

            if (values % 7 == 0) // 7의 배수 알아보기
            {
                Console.WriteLine("7의 배수입니다");

            }
            else
            {
                Console.WriteLine("7의 배수가 아닙니다");
            }
        }
    }
}
