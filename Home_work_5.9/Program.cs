using System;

namespace Home_work_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
            // M = 4; N = 8. -> ""4, 6, 7, 8""

            int m = 5; //Convert.ToInt32(Console.ReadLine());
            int n = 25; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Func(m, n));

            string Func(int start, int end)
            {
                if (start == end) return start.ToString();
                return (start + "," + Func(start + 1, end));
            }
        }
    }
}
