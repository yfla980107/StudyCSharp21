using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            //sb[6] = 'N'; //권장 안함
            sb.Append("My name is Hugo.\n");
            sb.Append("I'm \"47years\" old.\n"); // 특수문자 넣기
            sb.Append("Book price is 30000 won.\n");
            sb.Insert(6, "New"); //6번째자리에 New 넣기
            sb.Replace("Book", "시계"); // Book자리에 시계 넣기

            Console.WriteLine(sb);

            
        }
    }
}
