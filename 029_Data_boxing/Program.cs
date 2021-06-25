using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Data_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing   : boxing하는 과정에서 heap영역에 메모리가 할당된다. -> 프로그램이 무거워진다.
            // unboxing
            int i = 123;        // a value type
            object o = i;       // boxing
            int j = (int)o;     // unboxing
            i = 456;

            Console.WriteLine("i: {0}, o: {1}, j: {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));    // boxing: 메모리 참조 x
        }
    }
}
