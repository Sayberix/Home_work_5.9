using System;

namespace Home_work_5._9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m, n) = 29

            int m = 0; //Convert.ToInt32(Console.ReadLine());
            int n = 5; //Convert.ToInt32(Console.ReadLine());
            //int calcAnkerman = m, coefAnkerman = n + 3;
            if (m >= 0 && n >= 0)
                Console.WriteLine(calcAnkerman(n, m));
            else
            {
                Console.WriteLine("Для фукнции Анкермана вводимые числа должны быть >= 0!");
                return;
            }

            int calcAnkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return calcAnkerman(m - 1, 1);
                if (m > 0 && n > 0) return calcAnkerman(m - 1, calcAnkerman(m, n - 1));
                return calcAnkerman(n, m);
            }
        }
    }
}