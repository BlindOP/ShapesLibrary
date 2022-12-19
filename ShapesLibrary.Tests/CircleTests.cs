using Xunit;
using System.Collections.Generic;
using System;

namespace ShapesLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void IsNotCircle() //Проверка возникновения исключения если введены неправильные параметры треугольника
        {
            // Act
            Action act = () =>  new Circle(-1);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Incorrect triangle parameters", exception.Message);

        }
        [Fact]
        public void IsCircle() //Проверка отсутствия исключения если введены правильные параметры треугольника
        {
            // Act
            var exception = Record.Exception(() => new Circle(0.11));
            //Assert

            Assert.Null(exception);
        }
        [Fact]
        public void AreaCalculation()
        {
            //Arrange
            var circle = new Circle(4);

            //Assert
            Assert.Equal(50.26548, Math.Round(circle.GetArea(), 5));
        }
    }

}