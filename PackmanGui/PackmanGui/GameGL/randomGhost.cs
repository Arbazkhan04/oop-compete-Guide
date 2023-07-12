
using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackmanGui.GameGL
{
    public class randomGhost : Ghost
    {
        public GameObject previousGameObject;
       
        
        public randomGhost(Image img , GameCell currentCell, GameDirection gameDirection):base(img,currentCell,gameDirection)
        {
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCelol = currentCell.nextCell(gameDirection);
            previousGameObject = nextCelol.CurrentGameObject;
            this.CurrentCell = nextCelol;
            if(currentCell!= nextCelol)
            {
                currentCell.setGameObject(previousGameObject);
            }
            else if(generateRandomNumber()==0)
            {
                gameDirection = GameDirection.Up;
            }
           else if (generateRandomNumber() == 1)
            {
                gameDirection = GameDirection.Down;
            }
           else if (generateRandomNumber() == 2)
            {
                gameDirection = GameDirection.Left;
            }
           else
            {
            gameDirection = GameDirection.Right;
            }
            return currentCell;

        }

        private int generateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(4);
            return randomNumber;

        }
    }
}
