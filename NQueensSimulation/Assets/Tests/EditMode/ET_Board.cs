
using NUnit.Framework;
using NQueensSimulation;

namespace Tests
{
    public class ET_Board
    {
        int defaultSize = 4;
        Board testBoard = new Board();

        [Test]
        public void NewBoardIsSquareArray()
        {
            testBoard.ConstructBoard(defaultSize);

            Assert.AreEqual(defaultSize, testBoard.ReturnRowLength());
            Assert.AreEqual(defaultSize, testBoard.ReturnColumnLength());
            Assert.AreEqual(testBoard.ReturnRowLength(), testBoard.ReturnColumnLength());            
        }

        [Test]
        public void ReturnPositionValueIsNotNull()
        {
            int sixQueens = 4;

            testBoard.ConstructBoard(sixQueens);

            Assert.IsNotNull(testBoard.ReturnPositionValue(0,0));
            Assert.IsNotNull(testBoard.ReturnPositionValue(0,sixQueens-1));
            Assert.IsNotNull(testBoard.ReturnPositionValue(1,0));
            Assert.IsNotNull(testBoard.ReturnPositionValue(1,sixQueens-1));
            Assert.IsNotNull(testBoard.ReturnPositionValue(sixQueens-1,0));
            Assert.IsNotNull(testBoard.ReturnPositionValue(sixQueens-1,sixQueens-1));
        }

        [Test]
        public void SetPositionValueUpdatesPosition()
        {
            int newPosValue = 9;
            int oldPosValue;

            testBoard.ConstructBoard(defaultSize);

            oldPosValue = testBoard.ReturnPositionValue(1,1);

            testBoard.SetPositionValue(newPosValue, 1, 1);

            Assert.AreEqual(newPosValue, testBoard.ReturnPositionValue(1,1));
            Assert.AreNotEqual(oldPosValue, newPosValue);
        }

        [Test]
        public void PrintBoardYieldsNonEmptyString()
        {
            string emptyString= "";

            testBoard.ConstructBoard(defaultSize);

            Assert.IsNotNull(testBoard.PrintBoard());
            Assert.AreNotEqual(emptyString, testBoard.PrintBoard());
        }
    }
}
