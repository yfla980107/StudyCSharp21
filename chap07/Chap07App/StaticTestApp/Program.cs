using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number; //static number
        public float fnum;

        public static float ProSomething()
        {
            Console.WriteLine($"{number}, 먼가를 한다.");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass(); 
            TestClass.number = 10; // number은 new 인스턴스가 필요없음, fnum은 필요
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            bCls.fnum = 4.87f;

            TestClass.ProSomething();
        }
    }
}
