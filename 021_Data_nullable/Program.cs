using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Data_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // nullable: null 값 저장 가능 -> int? num = 100;
            // HasValue, Value 사용
            bool? isFlag = null;

            Console.WriteLine("isFlag: {0}", isFlag);
            Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);
            if (isFlag.HasValue)
            {
                Console.WriteLine("isFlag Value: {0}", isFlag.Value);
            }
        }
    }
}
