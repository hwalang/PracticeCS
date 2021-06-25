using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Data_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // object: 객체 데이터 형태 -> 어떤 데이터 형이든 모두 처리할 수 있다.
            object a = 3.14f;
            object b = false;
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
    }
}
