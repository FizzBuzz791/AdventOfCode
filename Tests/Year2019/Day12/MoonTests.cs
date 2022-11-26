using System.Collections.Generic;
using AdventOfCode.Year2019.Day12;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2019.Day12
{
    public class MoonTests
    {
        [TestCaseSource(nameof(VelocityCases))]
        public void VelocityIsAppliedCorrectly(Moon moon, Point3D velocity, Point3D expectedPosition)
        {
            // Arrange
            moon.Velocity.X = velocity.X;
            moon.Velocity.Y = velocity.Y;
            moon.Velocity.Z = velocity.Z;

            // Act
            moon.ApplyVelocity();

            // Assert
            moon.Position.ShouldBe(expectedPosition);
        }

        private static IEnumerable<object[]> VelocityCases()
        {
            yield return new object[] { new Moon("<x=1, y=2, z=3>"), new Point3D(-2, 0, 3), new Point3D(-1, 2, 6) };
        }
    }
}