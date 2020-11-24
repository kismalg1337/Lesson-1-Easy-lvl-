using System;

namespace ConsoleApp4
{
    class kvadrat
    {
        static void Main(string[] args)
        {
            //ax^2+bx+с
            //D=b^2-4ac
            Console.WriteLine("Введите a: ");
            if (double.TryParse(Console.ReadLine(), out double a) == false)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите b: ");
            if (double.TryParse(Console.ReadLine(), out double b) == false)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите c: ");
            if (double.TryParse(Console.ReadLine(), out double c) == false)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Environment.Exit(0);
            }

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                var x1 = (-b + Math.Sqrt(D)) / (2 * a);
                var x2 = (-b - Math.Sqrt(D)) / (2 * a);
                if (x1 != x2) {
                    Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                }
                else
                {
                    Console.WriteLine("x= {0}", x1);
                }
            }

            else
            {
                Console.WriteLine("Действительных корней нет");
            }
            
        }
    }
}
