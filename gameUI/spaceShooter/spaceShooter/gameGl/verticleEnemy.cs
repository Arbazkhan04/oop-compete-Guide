using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceShooter.gameGl
{
    public class verticleEnemy:gameEnemy
    {
        public GameObject previousGameObject;
        public verticleEnemy(Image img, GameCell currentCell, GameDirection gameDirection) : base(img, currentCell, gameDirection)
        {
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            previousGameObject = nextCell.CurrentGameObject;
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(previousGameObject);
            }
            else if (gameDirection == GameDirection.Up)
            {
                gameDirection = GameDirection.Down;
            }
            else
            {
                gameDirection = GameDirection.Up;
            }
            return currentCell;
        }
    }
}
