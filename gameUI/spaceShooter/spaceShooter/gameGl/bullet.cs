using PackmanGui.GameGL;
using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceShooter.gameGl
{
    public class Bullet : GameObject
    {
        private GameDirection direction;

        public Bullet(Image img, GameCell startCell, GameDirection direction) : base(GameObjectType.PLAYERBULLET, img)
        {
            this.CurrentCell = startCell;
            this.direction = direction;
        }

        public void Move()
        {
            // Calculate the next cell the bullet will move to.
            GameCell nextCell = this.CurrentCell.nextCell(direction);

            // Set the bullet as the game object for the next cell.
            nextCell.setGameObject(this);

            // Remove the bullet from the current cell.
            this.CurrentCell.setGameObject(Game.getBlankGameObject());

            // Update the bullet's current cell to the next cell.
            this.CurrentCell = nextCell;
        }
    }
}
