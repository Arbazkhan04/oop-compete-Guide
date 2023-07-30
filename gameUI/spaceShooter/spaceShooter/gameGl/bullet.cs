using PackmanGui.GameGL;
using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

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
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (currentCell == nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
                GamePlayer player = Game.getPlayer();
                player.bullets.Remove(this);
               
            }
            else
            {
           base.Img = Game.getImageForBullet(direction);
            //nextCell.setGameObject(this);
            this.CurrentCell.setGameObject(Game.getBlankGameObject());
            this.CurrentCell = nextCell;
            }
        }

    }
}
