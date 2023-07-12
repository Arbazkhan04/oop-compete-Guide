using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PackmanGui.GameGL
{
    public class HorizantalGhost :Ghost
    {
        public GameObject previosGameObject;
        public HorizantalGhost(Image img, GameCell cell,GameDirection gameDirection) : base(img, cell,gameDirection)
        {
        }

        public override GameCell move() //move ghost horizantal
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            previosGameObject = nextCell.CurrentGameObject;
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(previosGameObject);
            }
            else if(gameDirection == GameDirection.Right)
            {
                this.gameDirection = GameDirection.Left;
            }
            else
            {
                this.gameDirection = GameDirection.Right;
            }
           
            return currentCell;
        }
    }
}
