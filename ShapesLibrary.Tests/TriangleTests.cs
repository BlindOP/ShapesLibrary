using Xunit;
using System.Collections.Generic;
using System;

namespace ShapesLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void IsNotTriangle() //Проверка возникновения исключения если введены неправильные параметры треугольника
        {
            // Act
            Action act = () =>  new Triangle(2, 5, 3);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Incorrect triangle parameters", exception.Message);

        }

        [Fact]
        public void IsTriangle() //Проверка отсутствия исключения если введены правильные параметры треугольника
        {
            // Act
            var exception = Record.Exception(() => new Triangle(1, 1, 1));
            //Assert

            Assert.Null(exception);
        }
        [Fact]
        public void IsRightTriangle() //Проверка прямоугольны ли треугольник
        {
            //Arrange
            var triangle = new Triangle(1.41, 1, 1);

            //Assert
            Assert.True(triangle.IsRightTriangle);
        }
        [Fact]
        public void IsRightTriangle2() //Проверка прямоугольны ли треугольник
        {
            //Arrange
            var triangle = new Triangle(0.00000141, 0.000001, 0.000001);

            //Assert
            Assert.True(triangle.IsRightTriangle);
        }
        [Fact]
        public void AreaCalculation() // Проверка правильности подсчета площади
        {
            //Arrange
            var triangle = new Triangle(2, 5, 4);

            //Assert
            Assert.Equal(3.79967, Math.Round(triangle.GetArea(), 5));
        }
    }

}