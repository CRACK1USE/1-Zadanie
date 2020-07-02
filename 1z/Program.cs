using System;

namespace _1z
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c, d;
            double b, sum = 0;
            Console.WriteLine("Введите кол-во выстрелов: ");
            a = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Введите вероятность поражения мишени: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во попаданий от: ");
            c = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во попаданий до (включительно): ");
            d = Int16.Parse(Console.ReadLine());

            double[] riskList = new double[a + 1];
            for (int i = c; i <= a && c <= a && a >= d; i++)
            {
                riskList[i] = (factorial(a) / (factorial(i) * factorial(a - i) * 1.0)) * Math.Pow((1 - b), (a - i)) * Math.Pow((b), i);
            }

            for (int i = 0; i <= a && c <= a && a >= d; ++i)
            {
                sum += riskList[i];
            }

            for (int i = c; i <= a; ++i)
            {
                Console.WriteLine("Данные вероятности = " + Math.Round(riskList[i], 4));
            }
            Console.WriteLine("Сумма = " + Math.Round(sum, 4));
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            int fact = 1;

            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
