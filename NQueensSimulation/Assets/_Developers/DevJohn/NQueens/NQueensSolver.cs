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
        Board queensBoard = new Board();

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
            Debug.Log(queensBoard.PrintBoard());
        }

        #endregion

        //! All Private methods go here
        #region PrivateMethods
        

        #endregion
    }
}