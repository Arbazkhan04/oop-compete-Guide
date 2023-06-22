using System;
using System.Threading;
using EZInput;
using System.IO;
using PacMan.BL;

namespace PacMan
{
    class Program
    {

        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(10, 10,grid);
            PacmanPlayer player = new PacmanPlayer('P', start);
            printMaze(grid);
            printPlayer(player);
            Console.ReadKey();
        }
        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.row; x++)
            {
               
                for (int y = 0; y < grid.col; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    printCell(cell);
                   
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.y, cell.x);
            Console.Write(cell.currentGameObject.displayCharacter);
        }

        static void printPlayer(PacmanPlayer p)
        {
            Console.SetCursorPosition(p.cell.y,p.cell.x);
            Console.Write(p.displayCharacter);
        }
    }
}

