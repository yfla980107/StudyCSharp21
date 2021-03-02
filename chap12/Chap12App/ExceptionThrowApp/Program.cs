using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try // 메소드를 호출한 try ~catch문에서 받음
            {
                DoSomething(13);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

        }

        private static void DoSomething(int v) //메소드 내에서 예외를 던진 경우
        { 
                if (v <= 10) // 예외 발생
                {
                    Console.WriteLine($"v^2 = {v / 0}");
                }
                else
                {
                    throw new Exception("10보다 큰 값은 계산할 수 없습니다.");
                }

        }
    }
}

