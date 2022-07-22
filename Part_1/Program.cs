using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
//метод, определяющий длину окружности по заданному радиусу;
//метод, определяющий площадь круга по заданному радиусу;
//метод, проверяющий принадлежность точки с координатами (x, y) кругу с радиусом r и координатами центра x0, y0.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая часть: Находим прериметр и площадь окружности\nВведите радиус окружности");
            Double r = Convert.ToDouble(Console.ReadLine());
            double lengthCycle = Cycle.GetlengthCycle(r);
            double squareCycle = Cycle.GetsquareCycle(r);
            Console.WriteLine($"Периметр окружности = {lengthCycle:0.00} \nПлощадь окружности = {squareCycle:0.00}");
            Console.WriteLine("\nВторая часть\nПроверка положения точки");
            Console.WriteLine("Введите координаты точки");
            Console.Write("X=");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y=");
            Double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра и радиуса окружности");
            Console.Write("Xo=");
            Double х0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yo=");
            Double y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ro=");
            Double r0 = Convert.ToDouble(Console.ReadLine());
            string position = Cycle.Getposition(x, y, х0, y0, r0);
            Console.Write("{0}", position);
            Console.ReadKey();
        }
    }
}
