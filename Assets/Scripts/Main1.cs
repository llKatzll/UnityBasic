using System.Threading;
using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace Program
{
    abstract class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"안녕 나는 개쩌는{Name}다");
        }

        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { } //Dog 만드는데 Animal 도 같이 갑시다

        public override void MakeSound()
        {
            Console.Write("저는 가문의 명예를 이어받은 견(犬)의 귀공자,\n품위와 애정 모두 겸비한 강아지입니다.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            for(int i = 0; i < 99; i++)
            {
                Console.WriteLine("야아아아오오오오오오오옥");
            }
        }
    }

    class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.Write("저는 대지와 계절의 숨결을 품은,\n느긋함과 인내의 상징인 한 마리의 소입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("댕댕이");
            dog.MakeSound();
            Console.WriteLine();

            Animal cat = new Cat("나비");
            cat.MakeSound();
            Console.WriteLine();

            Animal cow = new Cow("해피카우");
            cow.MakeSound();
        }
    }

}