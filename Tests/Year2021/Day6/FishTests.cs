using AdventOfCode.Year2021.Day6;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2021.Day6
{
    public class FishTests
    {
        [Test]
        public void GivenAFish_WhenTheTimerIsFour_AndItTriesToSpawn_ThenItsTimerShouldReduceByOne()
        {
            // Arrange
            Fish fish = new(4);

            // Act
            var result = fish.TrySpawn();

            // Assert
            result.ShouldBeNull();
        }
    }
}