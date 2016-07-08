using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, d;

            Console.WriteLine("Вводите время в 12-ти часовом формате");
            Console.WriteLine("Сколько сейчас часов?");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 13)
                Console.WriteLine("Существует только 12 часов");

            Console.WriteLine("Сколько сейчас минут?");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 60)
                Console.WriteLine("Существует только 59 минут");
            c = m * 30;
            d = n * 6;

            if (m == 12) m = (n < 15) ? 0 : 12;
            if (m == 0) m = (n < 15) ? 0 : 12;


            int h = m * 5;
            int dhn = h - n;
            int delta = 0;

            if (dhn == 0)
            {
                delta = 15;
            }
            else if (dhn < 0) //минутная стрелка впереди часовой
            {
                dhn *= -1;
                if (dhn <= 15) //разница меньше = 15 минут
                    delta = 15 - dhn;
                else
                    delta = 45 - dhn;
            }
            else //часовая стрелка впереди
            {
                if (dhn < 15) //разница меньше 15 минут
                    delta = dhn + 15;
                else
                    delta = dhn - 15;
            }
            Console.WriteLine(delta + " минут до перпендикулярного состояния строк");
            Console.ReadKey();
        }
    }
}
