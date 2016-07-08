using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Трапеция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение большего основания");   //Ввод значения большего основания трапеции пользователем
            Double a = Convert.ToDouble(Console.ReadLine());   //Задаёт тип данных переменной и преобразует один тип данных в другой тип данных

            Console.WriteLine("Введите значение меньшего основания");   //Ввод значения меньшего основания трапеции пользователем
            Double b = Convert.ToDouble(Console.ReadLine());   //Задаёт тип данных переменной и преобразует один тип данных в другой тип данных

            Console.WriteLine("Введите значение боковой стороны");   //Ввод значения боковой стороны трапеции пользователем
            Double c = Convert.ToDouble(Console.ReadLine());   //Задаёт тип данных переменной и преобразует один тип данных в другой тип данных

            Console.WriteLine("Введите значение угла при большем основании");   //Ввод значения угла при большем основании трапеции пользователем
            Double t = Convert.ToDouble(Console.ReadLine());   //Задаёт тип данных переменной и преобразует один тип данных в другой тип данных

            Double S = c * Math.Sin(t) * (a - c * Math.Cos(t));   //Задёт тип данных переменной и считает площадь трапеции

            Console.WriteLine("Площадь трапеции "+S);   //Выводит на экран посчитанное значение площади трапеции
            Console.ReadKey();   //При нажатии любой клавиши консоль закрыватся
        }
    }
}
