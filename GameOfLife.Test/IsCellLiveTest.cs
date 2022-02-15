using Game_Of_Life;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class IsCellLiveTest
    {
        IsCellLive _isCellLive;

        [SetUp]
        public void SetUp()
        {
            _isCellLive = new IsCellLive();
        }

        [Test]
        public void GivenALiveCell_WhenCheckingIfTheCellsIsAliveOrDead_ShouldReturnTrue()
        {
            // Arrange
            char cell = '*';
            bool expected = true;

            // Act 
            bool result = _isCellLive.CellLive(cell);

            //Assert 
            Assert.AreEqual(expected, result);
        }
        public void GivenADeadCell_WhenCheckingIfTheCellsIsAliveOrDead_ShouldReturnFalse()
        {
            // Arrange
            char cell = '.';
            bool expected = false;

            // Act 
            bool result = _isCellLive.CellLive(cell);

            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}

