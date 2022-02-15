using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class NeighboursTest
    {
        Neighbours _neighbours;

        [SetUp]
        public void Setup()
        {
            _neighbours = new Neighbours();
        }
        [Test]
        public void GivenAnArrayOfNeigbours_WhenCountingLiveNeighbours_ShouldTheNumberOfLiveNeighbours()
        {
            // Arrange
            List<char> neighbours = new List<char>() { '.', '*', '.', '.', '*', '.', '*', '.', '*' };
            int expected = 4;

            // Act
            int result = _neighbours.LiveNeighbours(neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenAGridAndAnIndexOfACell_WhenFindingNeighbours_ShouldreturnAnArrayofNeighbours()
        {
            // Arrange
            char[,] grid = new char[,] { {'.','.','.' },
                                         {'.', '*' ,'.' },
                                         {'.', '*', '.' } };
            char[] expected = new char[] { '.', '.', '.', '.', '.', '.', '*', '.' };

            // Act
            List<char> result = _neighbours.GetNeighbours(grid, 1, 1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenAGridAndAnIndexOfACellPlacedOnACorner_WhenFindingNeighbours_ShouldReturnAnArrayOfNeighbours()
        {
            // Arrange
            char[,] grid = new char[,] { {'.','.','.' },
                                         {'.', '*' ,'.' },
                                         {'.', '*', '.' } };
            char[] expected = new char[] { '.', '.', '*' };

            // Act
            List<char> result = _neighbours.GetNeighbours(grid, 0, 0);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
