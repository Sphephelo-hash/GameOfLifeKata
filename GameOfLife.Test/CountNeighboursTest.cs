using System.Collections.Generic;
using Game_Of_Life;
using NUnit.Framework;

namespace GameOfLife.Test
{
    public class CountNeighboursTest
    {
        CountNeighbours _countNeighbours;

        [SetUp]
        public void Setup()
        {
            _countNeighbours = new CountNeighbours();
        }

        [Test]
        public void GivenAnArrayOfNeigbours_WhenCountingLiveNeighbours_ShouldTheNumberOfLiveNeighbours()
        {
            // Arrange
            List<char> neighbours = new List<char>() { '.', '*', '.', '.', '*', '.', '*', '.','*' };
            int expected =4;

            // Act
            int result = _countNeighbours.LiveNeighbours(neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
