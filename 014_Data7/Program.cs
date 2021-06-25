using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Data7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자 char ' ' -> 아스키 코드가 쓰인다
            char a = 'A';
            int num = (int)a;
            Console.WriteLine("a = {0}, 아스키코드 = {1}", a, num);


            // 문자열 string " "
            string str = "Hello World!";
            string str2 = str.Replace("Hello", "Hi");
            Console.WriteLine("str2: {0}", str2);
        }
    }
}
