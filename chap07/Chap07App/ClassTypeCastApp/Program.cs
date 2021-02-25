using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지(); // 강아지(자식)을  _포유류(부모)에 넣는건 가능
            _포유류.키우다();
            강아지 쭈쭈;

            if (_포유류 is 강아지)
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            ((강아지)_포유류).멍멍();
               _포유류.멍멍(); 이 문단은 불가능 부모가 자식을 참조하기때문
               _포유류 = new 고양이();
               _포유류.키우다();
               _포유류.야옹(); 이 문단은 불가능 부모가 자식을 참조하기때문*/

            /* = (강아지) new 포유류(); //부모가 자식한테 들어갈수없음*/

            강아지 뽀삐 = null;
            if (뽀삐 is 포유류) // 포유류(부모)를 뽀삐(자식)에 넣는건 불가능 실행안됨
            {
                Console.WriteLine("이 부분이 실행됨");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍(); //포유류에는 키우다 메소드만 존재 err
            }

            /*고양이 로미 = (고양이)new 포유류(); //부모가 자식한테 들어갈수없음
              로미.키우다();
              로미.야옹(); //포유류에는 키우다 메소드만 존재 err*/
        }
    }
}

