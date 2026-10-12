using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program45
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int abs = n < 0 ? -n : n;
                Console.WriteLine($"Модуль: {abs}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}