using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дейст.числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double b = Convert.ToInt32(Console.ReadLine());
            {
                if (a <= b)
                    a = 0;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
