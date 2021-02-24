using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");

            //Cat cat1 =  new Cat(); //고양이 객체의 실체(instance) 생성
            /*            Cat cat1 = new Cat(Name: "야옹이", Color: "흰색");
                        //cat1.Name = "야옹이";
                        //cat1.Color = "흰색";
                        cat1.Meow();

                        Cat kitty = new Cat();
                        kitty.Name = "헬로키티";
                        kitty.Color = "하얀색";
                        kitty.Meow();

                        Cat nero = new Cat();
                        nero.Name = "검은고양이 네로";
                        nero.Color = "검은색";
                        nero.Meow();*/

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();
        }
    }

    class Cat
    {
        public Cat() { }

        // ~Cat() {} //더이상 필요없음

        public Cat(string Name)
        {
            this.Name = Name; //this.Name 는 밑에 있는 ==public string Name 멤버변수 , Name은 바로 위 ==(String Name)이랑 같은거
        }

        public Cat(string Name, string Color) : this(Name) // 이 문단 this는 바로 위 name 재호출
        {
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender) : this (Name, Color) //위에있는 초기화되 있는 name과 color을 호출
        {
            this.Gender = Gender;
        }

        public string Name; //이름
        public string Color; //색상
        public string Gender; //성별

        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상{this.Color} / 성별{this.Gender}) : 야옹!");
        }
    }
}
