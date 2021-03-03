using System;

namespace UsingEventApp
{
    class Program
    {
        //이벤트가 발생했을때 실행되는 메서드(이벤트 핸들러)
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); // 이벤트를 내가 만든 로직이 있는 메서드랑 연결
            //somethinghappened이벤트에 myhandler 메소드를 이벤트 핸들러로 등록
            //이벤트 발생 시 이벤트 핸들러(myhandler) 호출

            for (int i = 0; i <= 100; i++)
            {
                notifier.DoSomething(i); 
            }
        }
    }
}
