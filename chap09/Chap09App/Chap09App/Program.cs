using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class MyClass
    {
        private int iValue; // 0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inC;

        public int IValue //프로퍼티
        {
            get
            {
                return this.iValue;
            }
            set
            {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                this.iValue = value;
            }
        }

        public MyClass(int iValue)
        {
            IValue = iValue;
        }

        /* public int GetValue()
         {
             return this.iValue;
         }

         public void SetValue(int iValue)
         {
             if (iValue < 0)
             {
                 this.iValue = 0;
             }
             else if (iValue > 120)
             {
                 this.iValue = 120;
             }
             else 
             {
             this.iValue = iValue;
             }
         }*/

        public void PrintValue()
        {
            Console.WriteLine($"값은 {IValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1200);
            myClass.PrintValue();

            //myClass.SetValue(108);// get, set을 안쓰면 메소드 형태로 데이터 삽입
            myClass.IValue = 1200; // get, set 사용시 변수형식으로 쉽게 데이터 삽입 가능
            myClass.PrintValue();
            //Console.WriteLine($"현재 온도는 {myClass.GetValue()}℃");
            Console.WriteLine($"현재 온도는 {myClass.IValue}℃");

        }
    }
}
