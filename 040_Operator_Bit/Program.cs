using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 게임 개발에 사용: flag

            // bit operator(4 byte 단위)
            // 비트 단위로 데이터를 처리: <<, >>

            // bit logical operator
            // &, |, ^(xor), ~(not)
            int a = 15;
            int b = 22;
            int c = a & b;
            Console.WriteLine("a & b = " + c);

            int d = a << 2;     // 왼쪽으로 2bit 이동: 4배 증가
            Console.WriteLine("d = " + d);

            // a 를 2진수 string형으로 변환, 32bit(4 byte)를 왼쪽부터 '0'으로 초기화
            string s = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine("s = " + s);
        }
    }
}
