using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения kx + b = 0!\n\n");
            //на случай возникновения exception, например, ввода строки вместо числа...
            try
            {
                Console.WriteLine("Введите коэффициент k:");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите коэффициент b:");
                double b = Convert.ToDouble(Console.ReadLine());

                Linear linear = new Linear(k, b);
                Console.WriteLine(linear.Root());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
