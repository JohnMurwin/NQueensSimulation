using UnityEngine;

namespace NQueensSimulation
{
    public class GridCreator : MonoBehaviour
    {
        #region Fields
        //* Public Variables
        public GameObject boardContainer;
        public GameObject blackTile;
        public GameObject whiteTile;
        public GameObject blackQueen;
        public GameObject whiteQueen;
        

        //* Protected Variables
        Board queensBoard;
        NQueensSolver nQueensSolver;


        //* Private Variables
        private int numberOfQueens;

        private GameObject [,] tiles;

        #endregion


        //* Any UNITY methods go here
        #region LifeCycle

        #endregion

        //? ALL Public methods go here
        #region PublicMethods

        /// <summary>
        /// Handles Solving the Problem & Displaying Result, primary method
        /// </summary>
        public void SolveProblem ()
        {
            //Clear grid and create new components
            foreach (Transform child in boardContainer.transform) {
                GameObject.Destroy(child.gameObject);
            }
                
            queensBoard = new Board();
            nQueensSolver = new NQueensSolver();

            //Then Create NQueens Board using Board
            queensBoard.ConstructBoard(numberOfQueens);
            tiles = new GameObject [numberOfQueens,numberOfQueens];

            //Then Generate Grid 'Board'
            GenerateGrid();

            //Then Call NQueensSolver
            Solver();
        }

        /// <summary>
        /// Helper method for taking Queens Size from input field and storing value
        /// </summary>
        /// <param name="s"></param>
        public void SetSize (string s)
        {
            string input = s;

            int.TryParse(s, out int result);    //using new .TryParse to output error if we cant parse instead of storing garbage
            
            numberOfQueens = result;

            if (numberOfQueens == 0)
            {
                //ToDo: set the input fields value to 0
            }       
        }

        #endregion

        //! All Private methods go here
        #region PrivateMethods
        private void GenerateGrid()
        {
            for(int i = 0; i < queensBoard.ReturnColumnLength(); i++)
            {
                for(int j = 0; j <queensBoard.ReturnColumnLength(); j++)
                {
                    if ((i + j) %2 == 0)    // figure out if board is in odd or even position
                    {
                        tiles[i,j] = Instantiate(blackTile);
                    }
                    else
                        tiles[i,j] = Instantiate(whiteTile);
                        
                    tiles[i,j].transform.SetParent(boardContainer.transform);   // store tile reference for later queen placement
                }
            }
        }

        private void Solver()
        {
            if (!nQueensSolver.Solve(queensBoard, numberOfQueens))
            {
                //ToDo: replace this with screen animation error
                Debug.Log("No solution was found....");
            }                
            else
            {
                //ToDo: replace this with screen animation
                Debug.Log("Solution: " + '\n' + queensBoard.PrintBoard());

                for(int i = 0; i < queensBoard.ReturnColumnLength(); i++)
                {
                    for(int j = 0; j <queensBoard.ReturnColumnLength(); j++)
                    {
                        GameObject temp;

                        if (queensBoard.ReturnPositionValue(i, j) == 1) // figure out if spot is actual solution spot
                        {
                            if ((i + j) %2 == 0)    // determine what queen to place
                            {
                                temp = Instantiate(whiteQueen);
                            }
                            else
                                temp = Instantiate(blackQueen);
                                
                            temp.transform.SetParent(tiles[i,j].transform); // set Queen icon position
                        }
                    }
                }

            }
            
        }

        #endregion
    }
}
