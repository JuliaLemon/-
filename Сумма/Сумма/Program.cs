using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, c, sum;
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
                if (a > 100)
            {
                Console.WriteLine("Ошибка! Число должно быть меньше или равно 100");
            }
            else
            {
                b = a % 100 / 10;
                c = a % 10;
                sum = b + c;
                Console.WriteLine("Сумма всех цифр числа равна " + sum);
            }
            Console.ReadKey();
        }
    }
}
