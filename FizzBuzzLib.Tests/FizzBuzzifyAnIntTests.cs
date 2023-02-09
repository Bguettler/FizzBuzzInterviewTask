namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using System.Collections.Generic;
    using System;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            //tests for FizzBuzzifyAnInt
            var FizzBuzz = new FizzBuzz();

            var output1 = FizzBuzz.FizzBuzzifyAnInt(1); //added in all tests together
            var output2 = FizzBuzz.FizzBuzzifyAnInt(3);
            var output3 = FizzBuzz.FizzBuzzifyAnInt(5);
            var output4 = FizzBuzz.FizzBuzzifyAnInt(15);
            output1.Should().Be("1");
            output2.Should().Be("Fizz");
            output3.Should().Be("Buzz");
            output4.Should().Be("FizzBuzz");

            //tests for FizzBuzzValuesForRange
            List<String> testStrings = new List<String>();
            List<String> answerStrings = new List<String>(new string[] { "1", "2", "Fizz", "4", "Buzz" }); //answer list used to compare

            foreach (var x in FizzBuzz.FizzBuzzValuesForRange(1, 5)) //loop to populate the teststrings list
            {
                testStrings.Add(x);
            }
            testStrings.Should().BeEquivalentTo(answerStrings); //comparing the two lists to see if they are the same

        }
    }
}
