using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Of_Life;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class ReplaceCellTest
    {
        ConvertCurrentCell _convertCurrentCell;
        [SetUp]
        public void SetUp()
        {
            _convertCurrentCell = new ConvertCurrentCell();
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
    }
}
