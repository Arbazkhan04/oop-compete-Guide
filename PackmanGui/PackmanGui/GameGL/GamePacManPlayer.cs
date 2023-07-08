using PackmanGui.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GameGL
{
    public class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(Image img ,GameCell startCell):base (GameObjectType.PLAYER,img) {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction) {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }
    }

    
}
