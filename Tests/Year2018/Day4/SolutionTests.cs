using System.Collections.Generic;
using AdventOfCode.Year2018.Day4;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2018.Day4
{
    public class SolutionTests
    {
        [TestCaseSource(nameof(Part1Cases))]
        public void FindsMostMinutesAsleep(string input, string expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day4 = new Solution(puzzle);

            // Act
            string mostMinutesAsleep = day4.SolvePart1();

            // Assert
            mostMinutesAsleep.ShouldBe(expectedResult);
        }

        private static IEnumerable<object[]> Part1Cases()
        {
            yield return new object[]
            {
                "[1518-11-01 00:00] Guard #1000 begins shift\n[1518-11-01 00:05] falls asleep\n[1518-11-01 00:25] wakes up\n[1518-11-01 00:30] falls asleep\n[1518-11-01 00:55] wakes up\n[1518-11-01 23:58] Guard #1099 begins shift\n[1518-11-02 00:40] falls asleep\n[1518-11-02 00:50] wakes up\n[1518-11-03 00:05] Guard #1000 begins shift\n[1518-11-03 00:24] falls asleep\n[1518-11-03 00:29] wakes up\n[1518-11-04 00:02] Guard #1099 begins shift\n[1518-11-04 00:36] falls asleep\n[1518-11-04 00:46] wakes up\n[1518-11-05 00:03] Guard #1099 begins shift\n[1518-11-05 00:45] falls asleep\n[1518-11-05 00:55] wakes up\n",
                "Guard #1000: Most asleep at 00:24."
            };
        }

        [TestCaseSource(nameof(Part2Cases))]
        public void MostCommonMinuteAsleep(string input, string expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day4 = new Solution(puzzle);

            // Act
            string mostCommonMinuteAsleep = day4.SolvePart2();

            // Assert
            mostCommonMinuteAsleep.ShouldBe(expectedResult);
        }

        private static IEnumerable<object[]> Part2Cases()
        {
            yield return new object[]
            {
                "[1518-11-01 00:00] Guard #1000 begins shift\n[1518-11-01 00:05] falls asleep\n[1518-11-01 00:25] wakes up\n[1518-11-01 00:30] falls asleep\n[1518-11-01 00:55] wakes up\n[1518-11-01 23:58] Guard #1099 begins shift\n[1518-11-02 00:40] falls asleep\n[1518-11-02 00:50] wakes up\n[1518-11-03 00:05] Guard #1000 begins shift\n[1518-11-03 00:24] falls asleep\n[1518-11-03 00:29] wakes up\n[1518-11-04 00:02] Guard #1099 begins shift\n[1518-11-04 00:36] falls asleep\n[1518-11-04 00:46] wakes up\n[1518-11-05 00:03] Guard #1099 begins shift\n[1518-11-05 00:45] falls asleep\n[1518-11-05 00:55] wakes up\n",
                "Guard #1099: Most asleep at 00:45."
            };
        }
    }
}