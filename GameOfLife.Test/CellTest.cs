using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameOfLife;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class CellTest
    {

        Cell _cell;

        [SetUp]
        public void SetUp()
        {
            _cell = new Cell();
        }

        [Test]
        public void GivenALiveCell_WhenCheckingIfTheCellsIsAliveOrDead_ShouldReturnTrue()
        {
            // Arrange
            char cell = '*';
            bool expected = true;

            // Act 
            bool result = _cell.CellLive(cell);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenADeadCell_WhenCheckingIfTheCellsIsAliveOrDead_ShouldReturnFalse()
        {
            // Arrange
            char cell = '.';
            bool expected = false;

            // Act 
            bool result = _cell.CellLive(cell);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenALiveCellWithNeighboursLessThan2_WhenConvertingCurrentCell_ShouldReturnADeadCell()
        {
            // Arrange
            bool isLive = true;
            int neighbours = 1;
            char expected = '.';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenALiveCellWithNeighboursGreaterThan3_WhenConvertingCurrentCell_ShouldReturnADeadCell()
        {
            // Arrange
            bool isLive = true;
            int neighbours = 5;
            char expected = '.';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenALiveCellWith2Neighbours_WhenConvertingCurrentCell_ShouldReturnALiveCell()
        {
            // Arrange
            bool isLive = true;
            int neighbours = 2;
            char expected = '*';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenALiveCellWith3Neighbours_WhenConvertingCurrentCell_ShouldReturnALiveCell()
        {
            // Arrange
            bool isLive = true;
            int neighbours = 3;
            char expected = '*';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenADeadCellWith3Neighbours_WhenConvertingCurrentCell_ShouldReturnALiveCell()
        {
            // Arrange
            bool isLive = false;
            int neighbours = 3;
            char expected = '*';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenADeadCellWithNeighboursGreaterThan3_WhenConvertingCurrentCell_ShouldReturnADeadCell()
        {
            // Arrange
            bool isLive = false;
            int neighbours = 5;
            char expected = '.';

            // Act
            char result = _cell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
