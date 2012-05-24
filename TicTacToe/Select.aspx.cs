using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StartGame(object sender, EventArgs e)
        {
            char playerSide = this.side.SelectedItem.Text.ToCharArray()[0];

            if (playerSide == 'X')
            {
                TicTacToe.sides[0] = 'X';
                TicTacToe.sides[1] = 'O';
            }
            else
            {
                TicTacToe.sides[0] = 'O';
                TicTacToe.sides[1] = 'X';
            }

            if (this.turn.Text.CompareTo("First") == 0)
            {
                TicTacToe.playerTurn = true;
            }
            else
            {
                TicTacToe.playerTurn = false;
            }

            TicTacToe.GameStarted();
            Response.Redirect("~/TicTacToe.aspx");
        }
    }
}