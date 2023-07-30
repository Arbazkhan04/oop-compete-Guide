using PackmanGui.GameGL;
using PacMan.GameGL;
using System.Drawing;

namespace spaceShooter.gameGl
{
    public class HorizontalEnemyBullet : EnemyBullet
    {
        private GameDirection direction;

        public HorizontalEnemyBullet(Image img, GameCell startCell, GameDirection direction) : base(img, startCell)
        {
            this.direction = direction;
        }

        public override void Move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (currentCell == nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
                enemyBullets.Remove(this);
            }
            else
            {
                base.Img = Game.getImageForBullet(direction);
                this.CurrentCell.setGameObject(Game.getBlankGameObject());
                this.CurrentCell = nextCell;
            }
        }

       
    }
}
