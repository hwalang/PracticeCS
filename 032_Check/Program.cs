using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';

            Console.WriteLine("a: {0}, a.GetType(): {1}", a, a.GetType());
            Console.WriteLine("b: {0}, b.GetType(): {1}", b, b.GetType());
            Console.WriteLine("c: {0}, c.GetType(): {1}", c, c.GetType());
            Console.WriteLine("d: {0}, d.GetType(): {1}", d, d.GetType());



            Console.Write("국어 점수: ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수: ");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수: ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("과학 점수: ");
            int sci = int.Parse(Console.ReadLine());

            int sum = kor + eng + math + sci;
            float average = sum / 4f;

            Console.WriteLine("국어: {0}, 영어: {1}, 수학: {2}, 과학: {3}", kor, eng, math, sci);
            Console.WriteLine("총점: {0}, 평균: {1}", sum, average);
        }
    }
}
