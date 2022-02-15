using GameOfLife;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class GameOfLifeTest
    {
        GameOfLife _gameoflife;

        [SetUp]
        public void SetUp()
        {
            _gameoflife = new GameOfLife();
        }

        [Test]
        public void GivenAGridWithOneDeadCellThatHas3Neighbours_WhenFindingTheNextGeneration_ShouldReturnANewGridWithTheCellReplacedByALivecell()
        {
            // Arrange
            char[,] cells = new char[,] { {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','*','*','.','.','.' },
                                            {'.','.','.','.','*','.','.','.' } };

            char[,] expected = new char[,] {{'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','*','*','.','.','.' },
                                            {'.','.','.','*','*','.','.','.' } };

            // Act
            char[,] result = _gameoflife.NextGeneration(cells);
          
            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenAGridWithOneLiveCellThatHasLessThan2Neighbours_WhenFindingTheNextGeneration_ShouldReturnANewGridWithTheCellReplacedByADeadCell()
        {
            // Arrange
            char[,] cells = new char[,] { {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','*','*','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' } };

            char[,] expected = new char[,] {{'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' },
                                            {'.','.','.','.','.','.','.','.' } };

            //Act
            char[,] result = _gameoflife.NextGeneration(cells);

            // Assert
            Assert.AreEqual(expected, result);
        }

        
    }
}
