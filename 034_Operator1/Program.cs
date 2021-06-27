using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Operator1
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators
            // &&(and), ||(or), !(not)

            // 삼항 operator ( 조건? A(true) : B(false) )
            int num = 0;
            bool result;

            result = (num == 0) ? true : false;
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("result: {0}", result);
        }
    }
}
