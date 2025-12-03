using System.Threading;
using System;
using System.Diagnostics;

namespace Program
{
    class Wizard
    {
        // =======================================
        // 1. Wizard 클래스를 만들어 다음 조건을 만족하세요:
        // 
        // - 멤버 변수: mp, intelligence (둘 다 int형)
        // - 생성자에서 각각 50, -999으로 초기화
        // - Main()에서 Wizard 객체를 생성하고 두 값을 출력
        //
        // [실행 결과]
        // 마법사의 MP: 50, 지능: 20
        // =======================================

        int mp;
        int intelligence;

        public Wizard()
        {
            mp = 50;
            intelligence = -999;
        }

        static void Main()
        {
            Wizard _wizard = new Wizard();

            Console.WriteLine("마법사의 MP:" + _wizard.mp + ", 지능: " + _wizard.intelligence);
            Console.WriteLine("듀..댜..뇌..창..던진..다!");
        }
    }
}