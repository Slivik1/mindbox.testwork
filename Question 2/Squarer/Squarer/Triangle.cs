using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squarer
{
    public class Triangle : Figure
    {
        private int side1;
        private int side2;
        private int side3;//Стороны треугольника

        public Triangle(int side1, int side2, int side3) //Инициализация сторон треугольника
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Square()//Метод для подсчета площади треугольника
        {
            if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))//Проверка треугольника на существование 
            {
                List<int> list = new List<int>();
                list.Add(side1);
                list.Add(side2);
                list.Add(side3);
                int hypotenuse = list.Max();//Поиск самой длинной стороны треугольника
                list.Remove(hypotenuse);
                int cathetus1 = list.Max();//Первый катет
                list.Remove(cathetus1);
                int cathetus2 = list.Max();//Второй катет
                list.Remove(cathetus2);

                if (Math.Pow(hypotenuse, 2) == Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2))//Проверка треугольника на прямоугольность
                {
                    double square = cathetus1 * cathetus2 / 2;//Подсчет площади прямоугольного треугольника
                    return square;
                }
                else
                {
                    double semiperimeter = (side1 + side2 + side3) / 2;//Подсчет полупериметра треугольника
                    double square = Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3)), 2);//Подсчет площади треугольника
                    return square;
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует!");
                return 0;
            }
        }
    }
}
