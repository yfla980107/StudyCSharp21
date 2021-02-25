using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class MyClass
    {   public void method3() { Console.WriteLine("Method3"); }
        public void method4() { Console.WriteLine("Method4"); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass _class = new MyClass();
            _class.method1();
            _class.method2();
            _class.method3();
            _class.method4();

        }
    }
}
