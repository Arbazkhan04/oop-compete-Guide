using PackmanGui.GameGL;
using PacMan.GameGL;
using spaceShooter.gameGl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceShooter.gameGl
{
    public  class horizantalEnmey:gameEnemy
    {
        public GameObject previosGameObject;
        public horizantalEnmey(Image img, GameCell cell, GameDirection gameDirection) : base(img, cell, gameDirection)
        {
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);

            if (nextCell != currentCell)
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
                {
                    if (gameDirection == GameDirection.Right)
                    {
                        gameDirection = GameDirection.Left;
                    }
                    else
                    {
                        gameDirection = GameDirection.Right;
                    }
                }
                else
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    this.CurrentCell = nextCell;
                }
            }
            else
            {
                if (gameDirection == GameDirection.Right)
                {
                    gameDirection = GameDirection.Left;
                }
                else
                {
                    gameDirection = GameDirection.Right;
                }
            }

            return currentCell;
        }
        public override void FireBullet(GameDirection direction)
        {
            // Calculate the next cell for the bullet based on the enemy's direction.
            GameCell nextCell = CurrentCell.nextCell(direction);

            // Create a new bullet and add it to the list at the next cell.
            HorizontalEnemyBullet bullet = new HorizontalEnemyBullet(Game.getBulletImage(), nextCell, direction);
            EnemyBullet.enemyBullets.Add(bullet);
        }
    }
}
