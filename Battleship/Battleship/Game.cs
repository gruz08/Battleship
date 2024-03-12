using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public void Start()
        {
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");
            currentPlayer = player1;

            SetupPlayers();

            while (!GameIsOver())
            {
                Console.Clear();
                currentPlayer.DisplayBoards();

                Console.WriteLine($"\n\n{currentPlayer.Name}, it's your turn.");
                Console.WriteLine("Enter coordinates to fire (e.g., C4): ");
                string input;
                do
                { 
                    input = Console.ReadLine().ToUpper();
                    int tempRow = currentPlayer.OpponentBoard.coordinateToInt(input).row;
                    int tempCol = currentPlayer.OpponentBoard.coordinateToInt(input).col; 
                    if (!(currentPlayer.OpponentBoard.grid[tempRow,tempCol] == 'X' || currentPlayer.OpponentBoard.grid[tempRow, tempCol] == 'M')) 
                    { 
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can't fire the same place twice.");
                    }
                } 
                while (true);
               
                if (currentPlayer.Fire(input, currentPlayer, player1, player2))
                {
                    Console.WriteLine("HIT! Take another turn.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Miss. Press Enter to switch turns.");
                    Console.ReadLine();
                    SwitchTurn();
                }
            }

            Player winner = (player1.OwnBoard.AllShipsSunk(currentPlayer, player1, player2)) ? player2 : player1;
            Console.WriteLine($"Congratulations, {currentPlayer.Name}! You won!");
            Console.ReadLine();
        }

        private void SetupPlayers()
        {
            Console.WriteLine($"{player1.Name}, set up your ships:");
            player1.SetupBoards();

            Console.WriteLine($"{player2.Name}, set up your ships:");
            player2.SetupBoards();
        }

        private void SwitchTurn()
        {
            currentPlayer = (currentPlayer == player1) ? player2 : player1;
        }

        private bool GameIsOver()
        {
            return player1.OwnBoard.AllShipsSunk(currentPlayer, player1, player2) || player2.OwnBoard.AllShipsSunk(currentPlayer, player1, player2);
        }
    }
}
