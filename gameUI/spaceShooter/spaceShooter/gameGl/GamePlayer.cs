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
    public class GamePlayer:GameObject
    { int score;
        public GamePlayer(Image img, GameCell startCell,GameDirection direction) : base(GameObjectType.PLAYER, img)
        {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            GameObjectType nextGameObjectType = nextCell.CurrentGameObject.GameObjectType;
            this.CurrentCell = nextCell;
            if (nextGameObjectType == GameObjectType.REWARD)
            {
                Score++;
            }
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            base.Img = Game.getImageForPlayer(direction);
            return nextCell;
        }

        public int Score { get => score; set => score = value; }
        public Image PlayerImage { get; private set; }
    }
}
