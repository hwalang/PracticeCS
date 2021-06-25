using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Data_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            // 형 변환
            // 정수 - (type)변수
            // 문자열 - ToString(), Parse() == Convert.변수
            decimal d = 3.141592m;
            string strD = d.ToString(); // "3.141592"

            Console.WriteLine("a.ToString(): " + strD);


            decimal parseD = decimal.Parse(strD);   // 3.141592m

            Console.WriteLine("decimal.Parse(): " + parseD);


            decimal convertD = Convert.ToDecimal(strD);

            Console.WriteLine("Convert.ToDecimal(): " + convertD);
        }
    }
}
