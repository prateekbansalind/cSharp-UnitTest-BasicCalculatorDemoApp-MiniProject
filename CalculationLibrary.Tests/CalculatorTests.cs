using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationLibrary.Tests
{
    
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(2, 0, 2)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act
            double actual = calc.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, -2, 4)]
        [InlineData(-4, 2, -6)]
        [InlineData(-2, -2, 0)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act
            double actual = calc.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, -2, -8)]
        [InlineData(-2, -2, 4)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act
            double actual = calc.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 4, 1)]
        [InlineData(2, 1, 2)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act
            double actual = calc.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }



    }
}
