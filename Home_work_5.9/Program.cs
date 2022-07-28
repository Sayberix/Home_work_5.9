using System;

namespace Home_work_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15-> 120
            // M = 4; N = 8. -> 30

            int m = 4; //Convert.ToInt32(Console.ReadLine());
            int n = 8; //Convert.ToInt32(Console.ReadLine());
            int sum = m;
            Console.WriteLine(Func(m, n));

            string Func(int start, int end)
            {
                if (start == end) 
                    return sum.ToString();
                else
                {
                    sum += start + 1;
                    return (Func(start + 1, end));
                }
                
            }
        }
    }
}
