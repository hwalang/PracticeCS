using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            // null 병합 연산자: null 값 체크
            // null인가(false) ?? 처리1(true): null이 맞으면 다른 값을 return
            int? a = null, c = null;
            int b = 10, d = 100;
            int result;

            result = a ?? b;
            Console.WriteLine("result = " + result);

            result = a ?? c ?? d;
            Console.WriteLine("result = " + result);
        }
    }
}
