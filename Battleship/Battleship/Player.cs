using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public string Name { get; }
        public Board OwnBoard { get; }
        public Board OpponentBoard { get; }
        public int ShipPartSunk = 0;

        public Player(string name)
        {
            Name = name;
            OwnBoard = new Board();
            OpponentBoard = new Board();
        }

        public void SetupBoards()
        {
            OwnBoard.PlaceShips();
        }

        public bool Fire(string coordinate, Player currentPlayer, Player player1, Player player2)
        {
            return OpponentBoard.Fire(coordinate, currentPlayer, player1, player2);
        }

        public void DisplayBoards()
        {
            Console.WriteLine($"{Name}'s Board:");
            OwnBoard.Display();
            Console.WriteLine("\nOpponent's Board:");
            OpponentBoard.Display();
        }
    }
}
