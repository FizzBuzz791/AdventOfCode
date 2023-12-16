using AdventOfCode.Year2023.Day1;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2023.Day1
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase("1abc2", 12)]
        [TestCase("pqr3stu8vwx", 38)]
        [TestCase("a1b2c3d4e5f", 15)]
        [TestCase("treb7uchet", 77)]
        [TestCase("1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet", 142)]
        public void Part1ReturnsExpectedResult(string input, int calibrationValues)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day1 = new Solution(puzzle);

            // Act
            string result = day1.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {calibrationValues}");
        }

        [TestCase("two1nine", 29)]
        [TestCase("eightwothree", 83)]
        [TestCase("abcone2threexyz", 13)]
        [TestCase("xtwone3four", 24)]
        [TestCase("4nineeightseven2", 42)]
        [TestCase("zoneight234", 14)]
        [TestCase("7pqrstsixteen", 76)]
        [TestCase("two1nine\neightwothree\nabcone2threexyz\nxtwone3four\n4nineeightseven2\nzoneight234\n7pqrstsixteen", 281)]
        public void Part2ReturnsExpectedResult(string input, int calibrationValues)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day1 = new Solution(puzzle);

            // Act
            string result = day1.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {calibrationValues}");
        }
    }
}