using System;
using System.Threading;
using EZInput;
using System.IO;
using PacMan.BL;
using System.Diagnostics;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(15, 11,grid);
            GameCell hGhostStart = new GameCell(1, 2, grid);//game cell for horizanttla ghsot
            PacmanPlayer player = new PacmanPlayer('P', start);//inheritaning the game object class 

            HorizantalGhost hGhost = new HorizantalGhost('G', hGhostStart);
            

            printMaze(grid);
            printPlayer(player);
            printPlayer(hGhost);

            // string movehorizantaly
            string direction = "Right";

            bool gameRunning = true;
            while(gameRunning)
            {
                
                Thread.Sleep(90);
                if(Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                      moveGameObject(player, GameDirection.Left);
                      
                    }

                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(player, GameDirection.Up);

                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(player, GameDirection.Down);

                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(player, GameDirection.Right);

                }
                moveHorizantalGhost(hGhost,  ref direction);
            }

            Console.ReadKey();
        }
        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Row; x++)
            {
               
                for (int y = 0; y < grid.Col;y++)
                {
                    GameCell cell = GameGrid.getCell(x, y);//check this code 
                    printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        static void printPlayer(gameObject p)
        {
            Console.SetCursorPosition(p.CurrentCell.Y,p.CurrentCell.X);
            Console.Write(p.DisplayCharacter);
        }

        static void moveGameObject(gameObject p, GameDirection direction)
        {
           
                GameCell nextCell = p.CurrentCell.nextCell(direction);
                if(nextCell != null)
                {
                    gameObject newGameObject = new gameObject(GameObjectType.None, ' ');
                    GameCell currentCell = p.CurrentCell;
                    clearContent(currentCell, newGameObject);
                    p.CurrentCell = nextCell;
                    printPlayer(p);
                }
               
            
        }

         static void moveHorizantalGhost(HorizantalGhost hGhostStart, ref string direction)
         {
          if(direction=="Right")
            {
                // GameCell nextCell = hGhostStart.CurrentCell.nextCell(GameDirection.Right);

                GameCell nextCell = hGhostStart.move();
               
                if (nextCell != null)
                {
                    gameObject newGameObject = new gameObject(GameObjectType.None, ' ');
                    GameCell currentCell = hGhostStart.CurrentCell;
                    clearContent(currentCell, newGameObject);
                    hGhostStart.CurrentCell = nextCell;
                    printPlayer(hGhostStart);
                }
                if (GameGrid.gameCell[nextCell.X, nextCell.Y + 1].CurrentGameObject.GameObjectType == GameObjectType.Wall)
                {
                    direction = "left";
                }

            }
          if(direction=="left")
            {
                GameCell nextCell = hGhostStart.CurrentCell.nextCell(GameDirection.Left);
                if (nextCell != null)
                {
                    gameObject newGameObject = new gameObject(GameObjectType.None, ' ');
                    GameCell currentCell = hGhostStart.CurrentCell;
                    clearContent(currentCell, newGameObject);
                    hGhostStart.CurrentCell = nextCell;
                    printPlayer(hGhostStart);
                }
                if (GameGrid.gameCell[nextCell.X, nextCell.Y - 1].CurrentGameObject.GameObjectType == GameObjectType.Wall)
                {
                    direction = "Right";
                }
            }
          

        }

        static void clearContent(GameCell currentCell,gameObject newGameObeject)
        {
            currentCell.CurrentGameObject = newGameObeject;
            Console.SetCursorPosition(currentCell.Y,currentCell.X);
            Console.Write(newGameObeject.DisplayCharacter);
        }
    }
}
