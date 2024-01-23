using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_10._1
{
    class Program
    {
        static void Main (string[] args)
        {
            //19
            try
            {
                Console.WriteLine("Введите количество строк");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов");
                int m = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int[,] arr = new int[n, m];
                Console.WriteLine("Введите a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите k1");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите k2");
                int k2 = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int p = 1;
                if (m > 0 || n > 0)
                {
                    if (a > 0 || b > 0 || k1 > 0 || k2 > 0)
                    {
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                arr[i, j] = rnd.Next(-51, 51);
                                Console.Write($"{arr[i, j],3}");
                                if (arr[i, j] % a == 0 || arr[i, j] % b == 0)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Числа кратные a или b {count}");

                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = k1; j <= k2; j++)
                            {
                                Console.Write($"{arr[i, j],3}");
                                if (arr[i, j] < 0)
                                {
                                    p *= arr[i, j];
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"{p}");
                    }
                    else
                    {
                        Console.WriteLine("Не то");
                    }
                }
                else
                { Console.WriteLine("Не то"); }
            }
            catch { Console.WriteLine("Вы ввели что то не то"); }
            Console.ReadLine();


            //7
           /* Console.Write("Количество строк (не менее 5): ");
            int m = int.Parse(Console.ReadLine());
            if (m >= 5)
            {
                Console.Write("Колиество столбцов (не менее 4): ");
                int n = int.Parse(Console.ReadLine());
                if (n >= 4)
                {
                    int[,] dvum = new int[m, n];
                    //заполнение массива                        for (int i = 0; i < dvum.GetLength(0); i++)
                    {
                        for (int j = 0; j < dvum.GetLength(1); j++)
                        {
                            Console.Write($"Введите число в {j + 1} столбец {i + 1} строку: ");
                            dvum[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("---------------------");
                    }
                    //вывод массива                        for (int i = 0; i < dvum.GetLength(0); i++)
                    {
                        for (int j = 0; j < dvum.GetLength(1); j++)
                        {
                            Console.Write($"{dvum[i, j],3}");
                        }
                        Console.WriteLine();
                    }                        //1 подпункт
                    int second_stolb = 0;
                    for (int i = 0; i < dvum.GetLength(0); i++)
                    {
                        if (dvum[i, 1] > 15)
                            second_stolb++;
                    }
                    Console.WriteLine($"Количество ненулевых чисел больше 15 во втором столбце: {second_stolb}");                        //2 подпункт
                    int sum5 = 0, kolvo5 = 0;
                    double sred5 = 0;
                    for (int j = 0; j < dvum.GetLength(1); j++)
                    {
                        if (dvum[4, j] % 2 != 0)
                        {
                            sum5 += dvum[4, j];
                            kolvo5++;
                        }
                    }
                    double str5 = sum5 / kolvo5;
                    sred5 = Math.Round(str5, 2);
                    Console.WriteLine($"Среднее арифметическое нечётных чисел 5 строки : {sred5}");                        //3 подпункт
                    int sum4 = 0, kolvo4 = 0;
                    double sred4 = 0;
                    for (int i = 0; i < dvum.GetLength(0); i++)
                    {
                        if (dvum[i, 3] % 4 == 0)
                        {
                            sum4 += dvum[i, 3];
                            kolvo4++;
                            Console.Write($"{dvum[i, 3],3}");
                        }
                    }
                    double stolb4 = sum4 / kolvo4;
                    sred4 = Math.Round(stolb4, 2);
                    Console.WriteLine($"Среднее арифметическое чисел 4 столбца кратных четырём: {sred4}");
                }
                else
                    Console.WriteLine("Вы произвели неправильный ввод");
            }
            else
                Console.WriteLine("Вы произвели неправильный ввод");*/
        }
    }
}
