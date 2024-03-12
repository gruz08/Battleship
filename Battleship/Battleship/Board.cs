using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        private const int BoardSize = 10;
        public readonly char[,] grid = new char[BoardSize, BoardSize];
        private readonly Ship[] ships = {
        new Ship(4), new Ship(3), new Ship(3), new Ship(2), new Ship(2),
        new Ship(2), new Ship(1), new Ship(1), new Ship(1), new Ship(1)
    };

        public Board()
        {
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    grid[i, j] = '~';
                }
            }
        }

        public void PlaceShips()
        {
            int a = 0;
            foreach (Ship ship in ships)
            {
                Console.WriteLine($"Placing ship of length {ship.Length}");
                for (int i = 0; i < ship.Length; i++)
                {
                    Console.WriteLine($"Enter coordinates for part {i + 1} of the ship (e.g., C4):");
                    string coordinate = Console.ReadLine().ToUpper();
                    int row = coordinate[0] - 'A';
                    int col = int.Parse(coordinate.Substring(1)) - 1;

                    if (!CanPlaceShip(row, col, ship.Length, i, a))
                    {
                        Console.WriteLine("Coordinates added wrong. Try again.");
                        i--;
                    }
                    else
                    {
                        ships[a].Coordinates = coordinate;
                        grid[row, col] = 'O';
                    }
                }
                Console.WriteLine("Ship placed successfully.");
                a++;
            }
        }

        private bool CanPlaceShip(int row, int col, int length, int index, int shipI)
        {
            if (row < 0 || row >= BoardSize || col < 0 || col >= BoardSize)
                return false;

            if (grid[row, col] == 'O')
                return false;

            if (index == 0)
            {
                for (int r = row - 1; r <= row + 1; r++)
                {
                    for (int c = col - 1; c <= col + 1; c++)
                    {
                        if (r >= 0 && r < BoardSize && c >= 0 && c < BoardSize && grid[r, c] == 'O')
                            return false;
                    }
                }
            }
            else
            {
                int prevRow = coordinateToInt(ships[shipI].Coordinates).row;
                int prevCol = coordinateToInt(ships[shipI].Coordinates).col;

                if (!(row == prevRow + 1 && col == prevCol) && !(row == prevRow - 1 && col == prevCol) && !(row == prevRow && col == prevCol + 1) && !(row == prevRow && col == prevCol - 1))
                    return false;
            }

            return true;
        }

        public (int row, int col) coordinateToInt(string coordinate)
        {
            int row = coordinate[0] - 'A';
            int col = int.Parse(coordinate.Substring(1)) - 1;
            return (row, col);
        }

        public void Display()
        {
            Console.Write("  ");
            for (int i = 1; i <= BoardSize; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            char rowLabel = 'A';
            for (int i = 0; i < BoardSize; i++)
            {
                Console.Write(rowLabel + " ");
                rowLabel++;
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write($"{grid[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public bool Fire(string coordinate, Player currentPlayer, Player player1, Player player2)
        {
            int row = coordinate[0] - 'A';
            int col = int.Parse(coordinate.Substring(1)) - 1;

            currentPlayer = (currentPlayer == player1) ? player2 : player1;

            if (currentPlayer.OwnBoard.grid[row, col] == 'O')
            {
                grid[row, col] = 'X';
                currentPlayer.ShipPartSunk++;
                return true;
            }
            else
            {
                grid[row, col] = 'M';
                return false;
            }
        }

        public bool AllShipsSunk(Player currentPlayer, Player player1, Player player2)
        {
            currentPlayer = (currentPlayer == player1) ? player2 : player1;

            if (currentPlayer.ShipPartSunk == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
