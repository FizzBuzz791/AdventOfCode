using AdventOfCode.Year2022.Day7;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day7
{
    public class SolutionTests
    {
        [TestCase("$ cd /\n$ ls\ndir a\n14848514 b.txt\n8504156 c.dat\ndir d\n$ cd a\n$ ls\ndir e\n29116 f\n2557 g\n62596 h.lst\n$ cd e\n$ ls\n584 i\n$ cd ..\n$ cd ..\n$ cd d\n$ ls\n4060174 j\n8033020 d.log\n5626152 d.ext\n7214296 k\n", 95437)]
        public void Part1ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day7 = new Solution(puzzle);

            // Act
            string result = day7.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {expectedResult}");
        }

        [TestCase("$ cd /\n$ ls\ndir a\n14848514 b.txt\n8504156 c.dat\ndir d\n$ cd a\n$ ls\ndir e\n29116 f\n2557 g\n62596 h.lst\n$ cd e\n$ ls\n584 i\n$ cd ..\n$ cd ..\n$ cd d\n$ ls\n4060174 j\n8033020 d.log\n5626152 d.ext\n7214296 k\n", 24933642)]
        public void Part2ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day6 = new Solution(puzzle);

            // Act
            string result = day6.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {expectedResult}");
        }
    }
}