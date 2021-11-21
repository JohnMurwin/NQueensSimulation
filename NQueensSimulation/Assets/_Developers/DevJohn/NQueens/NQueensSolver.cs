using UnityEngine;

namespace NQueensSimulation
{
    /// <summary>
    /// The NQueens Algorithm Solver Component
    /// </summary>
    public class NQueensSolver : MonoBehaviour
    {
        #region Fields
        //* Public Variables


        //* Protected Variables
        protected Board queensBoard = new Board();

        //* Private Variables
        [SerializeField]
        [Tooltip("Determines the starting number of Queens (and by extension the size of the board)")]
        private int numberOfQueens = 4;


        #endregion


        //* Any UNITY methods go here
        #region LifeCycle
        private void Start() {

            Debug.Log("Starting number of queens: " + numberOfQueens);

            queensBoard.ConstructBoard(numberOfQueens);

            Debug.Log("Starting Board: " + '\n' + queensBoard.PrintBoard());

            
            Solve();
        }

        #endregion

        //? ALL Public methods go here
        #region PublicMethods

        /// <summary>
        /// Solves the NQueens Algorithm based off the input value: numberOfQueens
        /// </summary>
        /// <returns>void</returns>
        public void Solve()
        {
            if (FindSolution(queensBoard, 0))
                Debug.Log("Could not find a solution... Either it doesnt exit, or something went wrong.");

            Debug.Log("Solved NQueens board for size: " + numberOfQueens + '\n' + queensBoard.PrintBoard());
        }

        #endregion

        //! All Private methods go here
        #region PrivateMethods
        private bool FindSolution (Board board, int col)
        {
            if (col >= numberOfQueens)  // our base case for when/if all Queens are placed on board
                return true;

            for (int i = 0; i < numberOfQueens; i++)    // start with current column and place Queen in row after row
            {
                if (CheckSafePlace(board, i, col)) // CheckSafePlace to see if we can place Queen here
                {
                    board.SetPositionValue(1, i, col);    // set space to 1 for successful Queen location

                    if (FindSolution(board, col + 1)) // recursive call to place the rest of the Queens
                        return true;
                }    

                board.SetPositionValue(0, i, col); // else we backtrack and set that spot to 0 and move onto next row [BACKTRACING] 
            }
            
            return false;   //Queen cannot be placed, so we return false
        }

        //* Note: since we are only placing from the left, we only need to check left spots, we assume right spots will always be open
        private bool CheckSafePlace (Board board, int rowLoc, int colLoc)
        {
            int i, j; // temp row/column values

            // check direct-left of current spot
            for (i = 0; i < colLoc; i++)
                if (board.ReturnPositionValue(rowLoc, i) == 1)
                    return false;

            // check upper-left of current spot
            for (i = rowLoc, j = colLoc; i >=0 && j >= 0; i--,j--)
                if (board.ReturnPositionValue(i,j) == 1)
                    return false;

            // check lower-left of current spot
            for (i = rowLoc, j = colLoc; j >=0 && i < numberOfQueens; i++, j--)
                if (board.ReturnPositionValue(i,j) == 1)
                    return false;

            return true;    //if none of the above checks fired, then its a safe spot to place Queen
        }
        

        #endregion
    }
}