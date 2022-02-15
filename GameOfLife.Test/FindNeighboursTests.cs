using NUnit.Framework;
using Game_Of_Life;
using System.Collections.Generic;

namespace GameOfLife.Test
{
    public class FindNeighboursTests
    {
        FindNeighbours _neighbours;

        [SetUp]
        public void Setup()
        {
            _neighbours = new FindNeighbours();
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