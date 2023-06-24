using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public class GameCell
    {
         int x;
         int y;
         gameObject currentGameObject;
         GameGrid gameGrid;

        public GameCell(int x, int y, GameGrid gameGrid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = gameGrid;
        }

        public GameCell nextCell(GameDirection gameDirection)
        {
            if (gameDirection == GameDirection.Left)
            {
                if (this.y > 0)
                {
                    GameCell ncell = GameGrid.getCell(x, y - 1);
                    if (ncell.currentGameObject.GameObjectType!= GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }

            if (gameDirection == GameDirection.Right)
            {
                if (this.y < this.gameGrid.Col - 1)
                {
                    GameCell ncell = GameGrid.getCell(x, y + 1);
                    if (ncell.currentGameObject.GameObjectType!=GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            if (gameDirection == GameDirection.Up)
            {
                if (this.x > 0)
                {
                    GameCell ncell = GameGrid.getCell(this.x - 1, this.y);
                    if (ncell.currentGameObject.GameObjectType!= GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }

            if (gameDirection == GameDirection.Down)
            {
                if (this.x < this.gameGrid.Row - 1)
                {
                    GameCell ncell = GameGrid.getCell(this.x + 1, y);

                    {
                        if (ncell.currentGameObject.GameObjectType!= GameObjectType.Wall)
                        {
                            return ncell;

                        }

                    }
                }
            }
                return this;
        }


        //getter and setter 
        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }

        public gameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
    }

}
