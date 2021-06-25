using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(): 한 번에 한 줄씩 "문자열" 로 입력 받는다.
            // ReadKey(): main의 args에 값을 넣을때
            Console.Write("정수를 입력하세요 ");
            string inputNum = Console.ReadLine();

            int num = int.Parse(inputNum);

            Console.WriteLine("입력한 수는 " + num + "입니다.");
        }
    }
}
