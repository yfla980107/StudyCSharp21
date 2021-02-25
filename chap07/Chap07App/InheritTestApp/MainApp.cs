using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
       protected string Name; //protected 상속클래스 접근가능

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

   /*     ~Parent()
        {
            Console.WriteLine($"{this.Name}.Parent() 소멸자");
        }*/

        public void ParentMethod()
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    class Child : Parent // 멤버변수를 상속받기 때문에 생략
    {
        public string Color; //색상


        public Child(string Name) : base(Name) //부모클래스의 파라미터값을 가져옴 this와 유사한 원리
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

    /*    ~Child()
        {
            Console.WriteLine($"{this.Name}.Child() 소멸자");
        }*/
        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

        public void getColor()
        {
            Console.WriteLine($"자식고유의 색은 {this.Color}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); //부모클래스 메소드 실행

            Child c = new Child("자식");
            c.Color = "황색";
            c.ParentMethod(); //부모의 메소드 실행
            c.ChildMethod(); //자식클래스 메소드 실행
            c.getColor();
        }
    }
}
