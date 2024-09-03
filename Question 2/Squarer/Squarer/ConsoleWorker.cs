using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squarer
{
    public class ConsoleWorker //Класс для работы с консолью
    {
        Figure Figure;
        int s1;
        int s2;
        int s3;
        int radius;

        public void TriangleSquare() //Метод подсчета площади треугольника
        {
            Console.WriteLine("Введите стороны треугольника...");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            s3 = Convert.ToInt32(Console.ReadLine());
            Figure = new Triangle(s1, s2, s3);
            var result = Figure.Square();
            Console.WriteLine($"Площадь треугольника равна: {result}");
            Figure = null;
            PrintMenu();
        }
        public void CircleSquare() //Метод подсчета площади круга
        {
            Console.WriteLine("Введите радиус круга...");
            radius = Convert.ToInt32(Console.ReadLine());
            Figure = new Circle(radius);
            var result = Figure.Square();
            Console.WriteLine($"Площадь круга равна: {result}");
            Figure = null;
            PrintMenu();
        }
        public void PrintMenu() //Метод, отображающий функционал библиотеки 
        {
            Console.WriteLine("Площадь какой фигуры посчитать:\n1 - Треугольник\n2 - Круг");
            var t = Convert.ToInt32(Console.ReadLine());
            switch (t) 
            {
                case 1:
                    Console.WriteLine();
                    TriangleSquare();
                    break;
                case 2:
                    Console.WriteLine();
                    CircleSquare();
                    break;
                default:
                    Console.WriteLine("Неверная команда");
                    PrintMenu();
                    break;
            }
        }
    }
}
