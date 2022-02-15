using Game_Of_Life;
using NUnit.Framework;

namespace GameOfLife.Test
{
    class TestNeighbours
    {
        Neighbours _neighbours;

        [SetUp]
        public void SetUp()
        {
            _neighbours = new Neighbours();
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
            char[,] result = _neighbours.NextGeneration(cells);
          
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

            char[,] expected = new char[,] {{'*','.','.','.','.','.','.','.' },
                                            {'.','*','.','.','.','.','.','.' },
                                            {'.','.','*','.','.','.','.','.' },
                                            {'.','.','.','*','*','.','.','.' } };

            //Act
            char[,] result = _neighbours.NextGeneration(cells);

            // Assert
            Assert.AreEqual(expected, result);
        }

        
    }
}
