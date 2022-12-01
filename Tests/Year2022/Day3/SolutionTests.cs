using AdventOfCode.Year2022.Day3;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day3
{
    public class SolutionTests
    {
        [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw\n", 157)]
        public void Part1ReturnsExpectedResult(string input, int prioritiesSum)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day3 = new Solution(puzzle);

            // Act
            string result = day3.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {prioritiesSum}");
        }

        [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw\n", 70)]
        public void Part2ReturnsExpectedResult(string input, int score)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day3 = new Solution(puzzle);

            // Act
            string result = day3.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {score}");
        }
    }
}