using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        public static bool playerTurn;
        public static char[] sides = new char[2];
        private static int[,] ticTacToe;
        private static bool hasWinner;

        public static void GameStarted()
        {
            hasWinner = false;
            ticTacToe = new int[,]
            {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                ComputerMove();
                playerTurn = true;
            }
        }
                 
        private static Random rand = new Random();
        private void ComputerMove()
        {
            if (!hasWinner)
            {                
                List<int> movesAvailable = new List<int>();   
                for (int i = 0; i < ticTacToe.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTacToe.GetLength(1); j++)
                    {
                        if (ticTacToe[i, j] == 0)
                        {
                            movesAvailable.Add(i * 3 + j);
                        }
                    }
                }
                FindWinningMove(movesAvailable);

                if (movesAvailable.Count == 0)
                {
                    PrintWinner(-1);
                }
                else if (!hasWinner)
                {
                    int moveIndex = rand.Next(movesAvailable.Count);
                    int move = movesAvailable[moveIndex];
                    int x = move / 3;
                    int y = move % 3;
                    ticTacToe[x, y] = 2;
                    ImageButton cell = (ImageButton)Page.FindControl("cell_" + (x + 1) + (y + 1));
                    cell.Enabled = false;
                    if (movesAvailable.Count == 1)
                    {
                        PrintWinner(-1);
                    }
                }

                RedrawTable();
            }
        }

        private void RedrawTable()
        {
            for (int i = 0; i < ticTacToe.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToe.GetLength(1); j++)
                {
                    ImageButton button = (ImageButton)Page.FindControl("cell_" + (i + 1) + (j + 1));

                    int imageSignIndex = ticTacToe[i, j] -1;
                    if (imageSignIndex >= 0)
                    {
                        button.ImageUrl = "~/" + sides[imageSignIndex] + ".jpg";
                        button.Enabled = false;
                    }
                }
            }            
        }

        private void FindWinningMove(List<int> availableMoves)
        {            
            foreach (int move in availableMoves)
            {
                int x = move / 3;
                int y = move % 3;
                ticTacToe[x, y] = 2;
                CheckForWinner();
                if (hasWinner)
                {
                    PrintWinner(2);
                    return;
                }
                else
                {
                    ticTacToe[x, y] = 0;
                }
            }
        }

        private void CheckForWinner()
        {
            for (int i = 0; i < ticTacToe.GetLength(0); i++)
            {
                if (ticTacToe[0, i] == ticTacToe[1, i] && ticTacToe[0, i] == ticTacToe[2, i]
                    && ticTacToe[0, i] != 0)
                {
                    hasWinner = true;
                    PrintWinner(ticTacToe[0, i]);
                    return;
                }
                else if (ticTacToe[i, 0] == ticTacToe[i, 1] && ticTacToe[i, 0] == ticTacToe[i, 2]
                    && ticTacToe[i, 0] != 0)
                {
                    hasWinner = true;
                    PrintWinner(ticTacToe[i, 0]);
                    return;
                }
            }
            if (ticTacToe[0, 0] == ticTacToe[1, 1] && ticTacToe[0, 0] == ticTacToe[2, 2]
                && ticTacToe[0, 0] != 0)
            {
                hasWinner = true;
                PrintWinner(ticTacToe[0, 0]);
                return;
            }
            if (ticTacToe[0, 2] == ticTacToe[1, 1] && ticTacToe[0, 2] == ticTacToe[2, 0]
                && ticTacToe[0, 2] != 0)
            {
                hasWinner = true;
                PrintWinner(ticTacToe[0, 2]);
                return;
            } 
        }

        private void PrintWinner(int winner)
        {
            if(winner == 1)
            {
                this.finish.Text = "Player wins!";
            }
            else if (winner == 2)
            {
                this.finish.Text = "Computer wins!";
            }
            else
            {
                this.finish.Text = "No winner";
            }
        }

        protected void PlayerMove(object sender, EventArgs e)
        {
            if (!hasWinner)
            {                
                ImageButton img = (ImageButton)sender;
                int playerX, playerY;
                GetPlayerMove(out playerX, out playerY, img.ID);
                ticTacToe[playerX, playerY] = 1;
                img.Enabled = false;
                CheckForWinner();
            }
            ComputerMove();
            RedrawTable();
        }

        private void GetPlayerMove(out int playerX, out int playerY, string imageID)
        {
            int xyValuesIndex = imageID.IndexOf('_');
            char Xposiotion = imageID[xyValuesIndex + 1];
            char Yposiotion = imageID[xyValuesIndex + 2];
            playerX = int.Parse(Xposiotion.ToString()) - 1;
            playerY = int.Parse(Yposiotion.ToString()) - 1;
        }
    }

}