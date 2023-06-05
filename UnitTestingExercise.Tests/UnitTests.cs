using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(4, 6, 2, 12)]
        [InlineData(2, 2, 3, 7)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]
        [InlineData(10,9,1)]
        [InlineData(5,2,3)]
        [InlineData(6,4,2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,20)]
        [InlineData(5,5,25)]
        [InlineData(2,2,4)]
        [InlineData(1,1,1)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]
        [InlineData(12,4,3)]
        [InlineData(10,2,5)]
        [InlineData(24,12,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
