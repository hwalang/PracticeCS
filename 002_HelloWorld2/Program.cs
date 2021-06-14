using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: 002_HelloWorld2
 * DESC: 메인 함수의 파라미터 보기
 * 
 *              <args에 값을 넣고 싶다면>
 *              
 * 002_HelloWorld2 -> bin -> debug 경로를 저장한 후
 * PracticeCS 폴더에서 프롬프트 창 열기
 *  1. cd..
 *  2. cd 저장한 경로 붙여넣기
 *  3. dir
 *  4. 002_HelloWorld2.exe 10(args에 저장한 파라미터)
 *  5. 'HelloWorld: 10' 이 출력된다.
 * 
 */

namespace _002_HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine("HelloWorld:" + args[0]);
            }
            else
            {
                Console.WriteLine("HelloWorld: args.Length = 0");
            }

            Console.ReadKey();
        }
    }
}
