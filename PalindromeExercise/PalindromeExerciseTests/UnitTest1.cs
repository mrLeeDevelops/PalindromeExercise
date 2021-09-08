using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("racecar",true)]
        [InlineData("palindrome", false)]
        [InlineData("civic", true)]
        [InlineData("duty", false)]
        [InlineData("redivider", true)]

        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
