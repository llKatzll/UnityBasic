using System.Threading;
using System;

namespace Program
{
    class Program
    {
        enum ClassType
        {
            None,
            Knight,
            Mage,
            Rogue
        }

        enum MonsterType
        {
            None,
            Slime,
            Orc,
            Skeleton
        }


        struct Player
        {
            public int hp;
            public int atk;
        }

        struct Monster
        {
            public int hp;
            public int atk;
        }

        static ClassType ClassChoice()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 마법사");
            Console.WriteLine("[3] 도둑");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Mage;
                    break;
                case "3":
                    choice = ClassType.Rogue;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.atk = 10;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 15;
                    break;
                case ClassType.Rogue:
                    player.hp = 75;
                    player.atk = 12;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    break;
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            var _rand = new Random();

            int _value = _rand.Next(0, 100);

            MonsterType _type;

            if(_value < 20)  //0~19 20%
            {
                _type = MonsterType.Slime;
            }
            else if (_value < 60) //20~59 40%
            {
                _type = MonsterType.Orc;
            }
            else if(_value < 90) //60~89 30%
            {
                _type = MonsterType.Skeleton;
            }
            else //10% GETOUT
            {
                _type = MonsterType.None;
            }

            monster = new Monster();

            switch (_type)
            {
                case MonsterType.Slime:
                    monster.hp = 15;
                    monster.atk = 2;
                    break;
                case MonsterType.Orc:
                    monster.hp = 50;
                    monster.atk = 5;
                    break;
                case MonsterType.Skeleton:
                    monster.hp = 25;
                    monster.atk = 8;
                    break;
                default:
                    monster.hp = 0;
                    monster.atk = 0;
                    break;
            }
        }

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;

            Player player;

            while (true)
            {
                choice = ClassChoice();
                if (choice != ClassType.None)
                {
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP {player.hp}, ATK {player.atk}");

                    Monster monster;
                    CreateRandomMonster(out monster);
                }
            }
        }
    }
}