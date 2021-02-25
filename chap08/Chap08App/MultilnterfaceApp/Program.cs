using System;

namespace MultilnterfaceApp
{

    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable //비행기 종류
    {
        void Fly();
    }

    class DronCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아");
        }

        public void Run()
        {
            Console.WriteLine("달려");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카");

            DronCar dreamCar = new DronCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnable car = dreamCar;
            car.Run();
           //car.Fly(); // IRunnable 부모인터페이스가 fly 접근 X

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = dreamCar;
            plane.Fly();
           //plane.Run(); // IFlyable 부모인터페이스가 Run 접근 X
        }
    }
}
