using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_Operator_infinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // 무한 반복: while(true), for(;;)
            // 게임 개발에 유용한 요소

            // 무한 루프 제어: break, continue
            int inputNum = 0;
            while(true) // for(;;)
            {
                Console.Write("(1)구구단 중 몇단? (2) 나가기(0번 입력) (3) 1단은 넘긴다: ");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0)
                {
                    Console.WriteLine("종료");
                    break;
                } else if (inputNum == 1)
                {
                    Console.WriteLine("1단은 넘깁니다. 다른 값을 입력해주세요.");
                    continue;
                    // Console.WriteLine("여긴 넘어간다.");
                }
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", inputNum, i, (inputNum * i));
                }
            }
        }
    }
}
