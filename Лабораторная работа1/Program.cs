using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Желова Александра ИУ5-33Б";
            Double A=0, B=0, C=0;
            if (args.Length != 0)
            {
                if (!double.TryParse(args[0], out A) || !double.TryParse(args[1], out B) || !double.TryParse(args[2], out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода");
                    Console.ResetColor();
                }
                else
                {
                    double.TryParse(args[0], out A);
                    double.TryParse(args[1], out B);
                    double.TryParse(args[2], out C);
                    Console.WriteLine("A={0}, B={1}, C={2}", A, B, C);
                }
            }
            else
            {
                Console.Write("Введите А: ");
                while (!double.TryParse(Console.ReadLine(), out A))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент А неверен, повторите ввод");
                    Console.ResetColor();
                }
                Console.Write("Введите B: ");
                while (!double.TryParse(Console.ReadLine(), out B))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент B неверен, повторите ввод");
                    Console.ResetColor();
                }
                Console.Write("Введите C: ");
                while (!double.TryParse(Console.ReadLine(), out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент C неверен, повторите ввод");
                    Console.ResetColor();
                }
                Console.WriteLine("A={0}, B={1}, C={2}", A, B, C);
            }
            //Console.WriteLine("Введите A: ");
            //A = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите B: ");
            //B = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите C: ");
            //C = Convert.ToDouble(Console.ReadLine());
            Resh myclass = new Resh(A, B, C);
            myclass.raschet();
            Console.ReadKey();
        }
    }
    class Resh
    {
        private double A, B, C, D, t1, t2, x1, x2, x3, x4;
        public Resh(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public void raschet()
        {
            if(A==0 & B==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Действительных корней нет");
                Console.ResetColor();
                Console.ReadKey();
            }
            D = Math.Pow(B, 2) - 4 * A * C;
            if (D > 0)
            {
                t1 = ((-1) * B + Math.Sqrt(D)) / (2 * A);
                t2 = ((-1) * B - Math.Sqrt(D)) / (2 * A);
                if (t1 >= 0 && t2 >= 0)
                {
                    x1 = Math.Sqrt(t1);
                    x2 = (-1) * Math.Sqrt(t1);
                    x3 = Math.Sqrt(t2);
                    x4 = (-1) * Math.Sqrt(t2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1= {0}\n x2= {1}\n x3= {2}\n x4= {3}\n ", x1, x2, x3, x4);
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                    if (t1 < 0 && t2 > 0)
                {
                    x1 = Math.Sqrt(t2);
                    x2 = (-1) * Math.Sqrt(t2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1= {0}\n x2= {1}\n ", x1, x2);
                    Console.ResetColor();
                }
                else
                        if (t2 < 0 && t1 > 0)
                {
                    x1 = Math.Sqrt(t1);
                    x2 = (-1) * Math.Sqrt(t1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1= {0}\n x2= {1}\n ", x1, x2);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
                if (D == 0)
            {
                t1 = ((-1) * B) / (2 * A);
                if (t1 >= 0)
                {
                    x1 = Math.Sqrt(t1);
                    x2 = (-1) * Math.Sqrt(t1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1= {0}\n x2= {1}\n  ", x1, x2);
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Действительных корней нет");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}


