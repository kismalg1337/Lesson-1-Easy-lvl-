using System;

namespace ConsoleApp1
{
    class del
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out var intA) == false)
            {
                Console.WriteLine("Вы ввели неверное значение");
                Environment.Exit(0);
            }
            if (int.TryParse(Console.ReadLine(), out var intS) == false)
            {
                Console.WriteLine("Вы ввели неверное значение");
                Environment.Exit(0);
            }
            if (intS != 0)
            {
                Console.WriteLine(Convert.ToDouble(intA) / Convert.ToDouble(intS));
            }
            else
            {
                Console.WriteLine("Делить на 0 нельзя");
            }
        }

    }
}
