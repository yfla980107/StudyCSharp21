using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Dog : Animal //animal의 자식 dog
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} : 멍멍!");
        }

        public void HowOld()
        {
            Console.WriteLine($"{this.Name}의 나이는 {this.Age}");
        }

    }
}
