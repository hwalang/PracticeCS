using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Data4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2진수, 16진수
            int a = 0b11111111;
            int b = 0xFF;

            // float(f), decimal(m), double
            float f = 123.456f;
            decimal d = 1234m;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("f: {0}", f);
            Console.WriteLine("d: {0}", d);
        }
    }
}
