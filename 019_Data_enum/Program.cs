using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Data_enum
{
    class Program
    {
        // enum: 열거형 데이터 이름 -> 코드의 가독성 향상
        enum DAY_OF_WEEK
        {
            SUN,    // 0
            MON,    // 1
            THE,
            WED,
            THU,
            FRI,
            SAT,
        }
        // 캐릭터 상태
        enum CHAR_STATE
        {
            IDLE,   // 멈춤
            WALK,
            RUN,
            DIE,
        }
        enum CLICK_STATE
        {
            NONE,   // 0
            CLICK = 100,    // 100
            DOUBLE_CLICK = 200, //200
            UP, // 201
        }

        static void Main(string[] args)
        {
            // (int) -> 현재 enum의 인덱스
            Console.WriteLine("{0}, {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);

            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태: {0}, {1}", charState, (int)charState);

        }
    }
}
