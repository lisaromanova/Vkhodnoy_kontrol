using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Z1()
        {
            Console.Write("Введите первое вещественное число: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе вещественное число: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double x3 = Math.Pow(x1, x2);
            Console.WriteLine("Полученное число: " + x3);
        }
        static void Z2()
        {
            Console.Write("Введите начальную координату x гипотенузы ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начальную координату y гипотенузы ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечную координату x гипотенузы ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечную координату y гипотенузы ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double gip = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double k1 = Math.Sqrt(Math.Pow(x2 - x2, 2) + Math.Pow(y2 - y1, 2));
            double k2 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y1, 2));
            double p = gip + k1 + k2;
            double s = k1 * k2;
            Console.WriteLine($"Площадь прямоугольного треугольника равна {s}\nПериметр прямоугольного треугольника {p}");
        }
        static void Z3()
        {
            Console.Write("Введите число: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double ost1 = x1 % 2;
            double ost2 = x1 % 3;
            if(ost1 == ost2)
            {
                Console.WriteLine($"Число {x1} дает одинаковый остаток на 2 и на 3");
            }
            else
            {
                Console.WriteLine($"Число {x1} не дает одинаковый остаток на 2 и на 3");
            }
        }
        static void Z4()
        {
            Console.Write("Введите число: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            string s = Convert.ToString(x1);
            Stack q = new Stack();
            foreach(char c in s)
            {
                q.Push(c);
            }
            foreach(char c in q)
            {
                Console.WriteLine(c);
            }
        }
        static void Z5()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToInt32(Console.ReadLine());
            double z = (1 + Math.Sin(x + 1)) / Math.Cos((12*y)-4);
            Console.WriteLine($"Полученное число: {z}");
        }
        static void Z6()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n*2];
            mas[0] = 1;
            mas[1] = 1;
            for(int i = 2; i < mas.Length; i++)
            {
                mas[i] = mas[i - 1] + mas[i - 2];
            }
            for(int i=1; i<mas.Length; i += 2)
            {
                Console.WriteLine($"Число {mas[i]} с индексом {i+1}");
            }
        }
        static void Z7()
        {
            Console.Write("Введите x: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            double i = 1;
            while (i <= n)
            {
                x += i / (i + 1);
                i++;
            }
            Console.WriteLine("Полученное число: " + x);
        }
        static void Z8()
        {
            int[] mas = new int[3];
            for(int i=0; i<mas.Length; i++)
            {
                Console.Write($"Введите результаты {i + 1} спортсмена ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = mas.Max();
            Console.WriteLine("Результат победителя заплыва: " + max);
        }
        static void Main(string[] args)
        {
            metka:  while (true)
            {
                
                try
                {
                    Console.Write("Введите задачу: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        Z1();
                        break;
                    }
                    else
                    {
                        if (n == 2)
                        {
                            Z2();
                            break;
                        }
                        else
                        {
                            if (n == 3)
                            {
                                Z3();
                                break;
                            }
                            else
                            {
                                if (n == 4)
                                {
                                    Z4();
                                    break;
                                }
                                else
                                {
                                    if (n == 5)
                                    {
                                        Z5();
                                        break;
                                    }
                                    else
                                    {
                                        if (n == 6)
                                        {
                                            Z6();
                                            break;
                                        }
                                        else
                                        {
                                            if (n == 7)
                                            {
                                                Z7();
                                                break;
                                            }
                                            else
                                            {
                                                if (n == 8)
                                                {
                                                    Z8();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Такой задачи не существует! Повторите ввод");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Повторите ввод");
                }
                
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Хотите повторить работу программы?\n1-Да 2-Нет");
                    int z = Convert.ToInt32(Console.ReadLine());
                    if (z == 2)
                    {
                        break;
                    }
                    else
                    {
                        if (z == 1)
                        {
                            goto metka;
                        }
                        else
                        {
                            Console.WriteLine("Неверное значение! Повторите ввод");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Повторите ввод");
                }

            }
        }
    }
}