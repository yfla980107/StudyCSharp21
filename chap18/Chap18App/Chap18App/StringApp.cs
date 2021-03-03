using System;

namespace Chap18App
{
    class StringApp
    {
        string temp2 = "Global Variable String"; // var 불가 전역변수
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            // 기본 선언
            string message1 = null;
            Console.WriteLine($"null 문자열 : { message1 }.");
            string message2 = String.Empty; // == "" 같은뜻
            Console.WriteLine($"빈값 문자열 : { message2 }.");
            string oldPath = "C:\\Program Files\\Bandizip"; //폴더, 파일 경로
            string newPath = @"C:\Program Files\Bandizip"; // oldPath랑 차이는 @와 \\

            String greeting = "Hello World!"; //string == String 차이 없음
            var temp1 = "Local Variable String"; // 지역변수에만

            char[] lettes = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(lettes);// char를 string으로 형변환해줌
            Console.WriteLine($"{hello}");

            string s1 = "Hello ";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            string row = "Row1\r\nRow2\r\nRow3"; // 표준 줄바꿈1
            Console.Write(row);

            Console.WriteLine(" --- ");
            string row2 = "Row11\nRow22\nRow33"; // \n만해도 값은 정상적으로 나옴(가장짧음) 줄바꿈2
            Console.Write(row2);

            Console.WriteLine();
            Console.Write($"Row111{Environment.NewLine}Row222{Environment.NewLine}Row333"); //줄바꿈3

            string oldline = "Test" + // 다 붙어서 출력
                "Test2" +
                "Test3 ";
            string multline = @"New Test 
These are multline
end."; //텍스트 그대로 출력
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multline);

            Console.WriteLine($"\U0001F47D"); //👽

            var book = (lastName: "박", firstName: "상현", title: "이것이 C#이다", company: "한빛미디어",
                releaseDate: "2018-07-01", price: 30000, page: 812);

            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.Write($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간, ");
            Console.WriteLine($" 페이지수{book.page}, 금액:{book.price:#,###}원");

            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = " Visual C# Express "; // 총 19자리
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim()); //스페이스(여백) 삭제
            var s6 = s5.Trim(); // 총 17자리 "Visual C# Express"

            Console.WriteLine(s6.Substring(7)); //8번째 문자부터 출력
            Console.WriteLine(s6.Substring(7, 2));

            Console.WriteLine(s6.Replace("C#", "Basic")); // C# 를 Basic 로 변경
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic")); 
            // 7번째 문자에서 뒤로 2문장을 없애고 Basic를 삽입

            Console.WriteLine(s6.IndexOf("C")); // 7 : C가 있는 인덱스값
            Console.WriteLine(s6.Length); // 17 : 문자열 길이
            Console.WriteLine(s6.ToLower()); //소문자 변환
            Console.WriteLine(s6.ToUpper()); //대문자 변환

            //null문자열 빈문자열
            Console.WriteLine("null/빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr); // hello 출력
            Console.WriteLine(nullstr == emptystr); //false
            
            try
            {
                Console.WriteLine(nullstr.Equals(emptystr)); // 예외발생
                Console.WriteLine(emptystr.Length); // 0
                Console.WriteLine(nullstr.Length); // 예외발생
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
        }
    }
}
