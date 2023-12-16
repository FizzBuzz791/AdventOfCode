using System.Collections;
using AdventOfCode.Year2023.Day2;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2023.Day2
{
    [TestFixture]
    public class GameTests
    {
        [TestCaseSource(typeof(GameTestsData), nameof(GameTestsData.DetermineMaximumsData))]
        public void DetermineMaximums(string[] input, int expectedRed, int expectedBlue, int expectedGreen)
        {
            // Arrange
            var game = new Game(1);

            // Act
            game.DetermineMaximums(input);

            // Assert
            game.MaxRed.ShouldBe(expectedRed);
            game.MaxBlue.ShouldBe(expectedBlue);
            game.MaxGreen.ShouldBe(expectedGreen);
        }
    }

    public static class GameTestsData
    {
        public static IEnumerable DetermineMaximumsData
        {
            get
            {
                yield return new TestCaseData(new string[] { "1 red" }, 1, 0, 0);
                yield return new TestCaseData(new string[] { "2 blue" }, 0, 2, 0);
                yield return new TestCaseData(new string[] { "3 green" }, 0, 0, 3);
                yield return new TestCaseData(new string[] { "1 red, 2 blue, 3 green" }, 1, 2, 3);
                yield return new TestCaseData(new string[] { "2 red", "1 red" }, 2, 0, 0);
            }
        }
    }
}