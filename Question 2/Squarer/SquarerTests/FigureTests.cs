using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squarer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Squarer.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void CircleSquareTest()//Юнит-тест для метода Square() в классе Circle
        {
            //arrange
            int radius = 2;
            double expected = 12.57;//ожидаемый результат

            //act
            Circle circle = new Circle(2);
            double actual = circle.Square();//фактический результат

            //assert
            Assert.AreEqual(expected, actual);//сравнение ожидаемого и фактического результатов
        }
        [TestMethod()]
        public void TriangleRectangularSquareTest()//Юнит-тест для метода Square() в классе Triangle(ветка прямоугольного треугольника)
        {
            //arrange
            int corner1 = 7;
            int corner2 = 25;
            int corner3 = 24;
            double expected = 84;//ожидаемый результат

            //act
            Triangle triangle = new Triangle(7, 25, 24);
            double actual = triangle.Square();//фактический результат

            //assert
            Assert.AreEqual(expected, actual);//сравнение ожидаемого и фактического результатов
        }
        [TestMethod()]
        public void TriangleNullSquareTest()//Юнит-тест для метода Square() в классе Triangle(ветка несуществующего треугольника)
        {
            //arrange
            int corner1 = 4;
            int corner2 = 5;
            int corner3 = 10;
            double expected = 0;//ожидаемый результат

            //act
            Triangle triangle = new Triangle(4, 5, 10);
            double actual = triangle.Square();//фактический результат

            //assert
            Assert.AreEqual(expected, actual);//сравнение ожидаемого и фактического результатов
        }
        [TestMethod()]
        public void TriangleSquareTest()//Юнит-тест для метода Square() в классе Triangle(ветка произвольного треугольника)
        {
            //arrange
            int corner1 = 2;
            int corner2 = 2;
            int corner3 = 2;
            double expected = 1.73;//ожидаемый результат

            //act
            Triangle triangle = new Triangle(2, 2, 2);
            double actual = triangle.Square();//фактический результат

            //assert
            Assert.AreEqual(expected, actual);//сравнение ожидаемого и фактического результатов
        }
    }
}