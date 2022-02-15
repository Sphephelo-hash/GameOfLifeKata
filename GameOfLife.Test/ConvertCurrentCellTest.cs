using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Of_Life;

namespace GameOfLife.Test
{
    public class ConvertCurrentCellTest
    {
        ConvertCurrentCell _convertCurrentCell;
        [SetUp]
        public void SetUp()
        {
            _convertCurrentCell=new ConvertCurrentCell();
        }

        [Test]
        public void GivenALiveCellWithNeighboursLessThan2_WhenConvertingCurrentCell_ShouldReturnADeadCell()
        {
            // Arrange
            bool isLive = true;
            int neighbours = 1;
            char expected = '.';

            // Act
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

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
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

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
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

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
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

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
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

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
            char result = _convertCurrentCell.ConvertCurrentChar(isLive, neighbours);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
