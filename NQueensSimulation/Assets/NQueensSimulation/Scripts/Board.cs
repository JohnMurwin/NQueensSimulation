using System.Text;

namespace NQueensSimulation
{
    public class Board 
    {
        #region Fields
        //* Public Variables

        //* Protected Variables

        //* Private Variables
        private int [,] board;

        #endregion

        //? ALL Public methods go here
        #region PublicMethods

        /// <summary>
        /// Constructs an empty, square 2D integer array based off size input
        /// </summary>
        /// <param name="squareSize">the number of columns and rows this 'board' should have</param>
        public void ConstructBoard (int squareSize)
        {
            board = new int[squareSize, squareSize];

            for (int i = 0; i < squareSize; i++)
            {
                for (int j = 0; j < squareSize ; j++)
                {
                    board[i,j] = 0;
                }
            }
        }

        /// <summary>
        /// Returns the integer value of any particular position in the 2D array
        /// </summary>
        /// <param name="row">Row # of the desired position</param>
        /// <param name="col">Column # of the desired position</param>
        /// <returns></returns>
        public int ReturnPositionValue(int row, int col)
        {
            return board[row,col];
        }

        /// <summary>
        /// Sets an integer value at any particular position in the 2D array
        /// </summary>
        /// <param name="desiredValue">The value to set in the position the board</param>
        /// <param name="row">Row # of the desired position</param>
        /// <param name="col">Column # of the desired position</param>
        public void SetPositionValue (int desiredValue, int row, int col)
        {
            board[row, col] = desiredValue;
        }

        /// <summary>
        /// Uses the number of rows to find length
        /// </summary>
        /// <returns>int value of row length</returns>
        public int ReturnRowLength () 
        {
            return board.GetLength(0);
        }

        /// <summary>
        /// Uses the number of columns to find length
        /// </summary>
        /// <returns>int value of column length</returns>
        public int ReturnColumnLength () 
        {
            return board.GetLength(1);            
        }

        /// <summary>
        /// Prints the board state as a single string using StringBuilder
        /// </summary>
        /// <returns>string value of board</returns>
        //ToDo: might want to remove this and make it either an extension method, or a static external method
        public string PrintBoard()
        {
            StringBuilder boardOutput = new StringBuilder();    //make string builder

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0) ; j++)
                {
                    boardOutput.Append(board[i, j]);    //store value at point [i,j]
                    boardOutput.Append(" ");    //give space for formatting
                }

                boardOutput.AppendLine();   //new line for new row
            }

            return boardOutput.ToString(); //output
        }

        #endregion

        //! All Private methods go here
        #region PrivateMethods
        

        #endregion
    }
}
