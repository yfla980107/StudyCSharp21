using System;

namespace PropertyTestApp
{
    // 생일정보 클래스
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name //프로퍼티 사용
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Birthday //프로퍼티 사용
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public string GetName() //일반 Get/Set 메소드 사용
        {
            return this.name;
        }

        public void SetName(string name) //일반 Get/Set 메소드 사용
        {
            this.name = name;
        }

        public DateTime GetBirthday() //일반 Get/Set 메소드 사용
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday) //일반 Get/Set 메소드 사용
        {
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 Get/Set 메소드 사용");
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");


            Console.WriteLine("프로퍼티 사용");
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순"; //set value가 되는값: 홍길순
            info2.Birthday = new DateTime(1992, 3, 16); //set value가 되는값: DateTime(1992, 3, 16)

            Console.WriteLine($"이름 : {info2.Name}"); //get
            Console.WriteLine($"생일 : {info2.Birthday}"); //get

        }
    }
}
