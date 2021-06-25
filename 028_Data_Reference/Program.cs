using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Data_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            // 참조형(reference): 주소를 참조 -> 두 변수가 서로 영향을 미친다.
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr: {0}, ReferenceEquals: {1}", num, Object.ReferenceEquals(num, refNum));



            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum;
            refArrNum[0] = 1000;

            Console.WriteLine("refStr: {0}, RefernceEquals: {1}", arrNum[0], Object.ReferenceEquals(arrNum, refArrNum));

        }
    }
}
