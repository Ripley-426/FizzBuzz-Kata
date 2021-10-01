using Xunit;
using System.Collections.Generic;

namespace Kata
{
    public class FizzBuzzTests
    {
        private FizzBuzzClass _fb;

        // Arrange
        public FizzBuzzTests()
        {
            _fb = new FizzBuzzClass();
        }

        //Single number
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetFizzBuzz_Number_FizzBuzzResult(int number, string expected)
        {
            // Act
            var result = _fb.GetFizzBuzz(number);
            // Assert
            Assert.Equal(expected, result);
        }

        //List
        [Theory]
        [InlineData(16, 8, "8")]
        [InlineData(10, 9, "Fizz")]
        [InlineData(12, 10, "Buzz")]
        [InlineData(100, 90, "FizzBuzz")]
        public void GetFizzBuzzList_ListLenghtAndNumber_FizzBuzzResult(int listLength, int numberToCheck, string expected)
        {
            // Act
            List<string> fizzBuzzlist = _fb.GetFizzBuzzList(listLength);
            string result = fizzBuzzlist[numberToCheck];
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
