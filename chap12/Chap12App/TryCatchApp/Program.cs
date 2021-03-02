using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 108, y = 0;
            int result = 0;


            // 문법적 오류가 아니라 컴파일에서는 에러가 안남 == 예외
            try
            {
                for (int i = 0; i < 5; i++) //첫번째코드에서 예외발생시
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }

                result = x / y; //두번째코드에서 예외발생시
                Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex) //첫번째예외 처리 한번 발생 - trycatch문 빠져나감
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex) //두번째예외 처리 한번 발생 - trycatch문 빠져나감
            {
                Console.WriteLine($"예외발생 : {ex.Message}");

            }
            catch (Exception ex) //모든 예외클래스는 exception 형식으로 간주
            {
                Console.WriteLine($"예외발생 : {ex.Message}");

            }

            Console.WriteLine($"나머지 일처리 계속 ...");

            string strVal = "Hello World!";

            try
            {
                string spliVal = strVal.Substring(6, 5); //6번째자리에서 5개의 문자 출력
                Console.WriteLine($"자른 문자 : {spliVal}");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. 값을 입력하세요 . {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화하세요. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"기타 예외발생. {ex.Message}");
            }

            Console.WriteLine("일처리 또 있음...");


        }
    }
}
