using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Data_var
{
    class Program
    {
        // var x
        static void Main(string[] args)
        {
            // var: 선언과 동시에 초기화, 지역 변수로만 사용 -> for ~ each 에서 자주 사용
            var a = 100;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
        }
    }
}
