using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squarer
{
    public class Circle : Figure
    {
        private int radius;//Радиус для подсчета площади круга

        public Circle(int radius) { this.radius = radius; }//Инициализация значения радиуса

        public override double Square()
        { 
            double square = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            return square;
        }
    }
}