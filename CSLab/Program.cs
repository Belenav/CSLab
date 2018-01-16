using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, x;
            double result1, result4;
            bool result2, result3; 

            Console.Write("Введите значение n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение m: ");
            m = Convert.ToInt32(Console.ReadLine());

            result1 = n++ + m;

            Console.WriteLine($"result1={result1}, n={n}\n");

            result2 = m-->n;
            Console.WriteLine($"result2={result2}, m={m}\n");

            result3 = n-- > m;
            Console.WriteLine($"result3={result3}, n={n}\n");

            Console.Write("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());

            result4 = Math.Sin(x)+Math.Pow(x,3)+1/(Math.Pow(x,2)+1);
            Console.WriteLine($"result4={result4}");

            Console.ReadKey();
        }
    }
}
