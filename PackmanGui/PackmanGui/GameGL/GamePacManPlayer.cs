using PackmanGui.GameGL;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GameGL
{
    public class GamePacManPlayer : GameObject
    {
        int score;
        public GamePacManPlayer(Image img ,GameCell startCell):base (GameObjectType.PLAYER,img) {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction) {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            GameObjectType nextGameObjectType = nextCell.CurrentGameObject.GameObjectType;
            this.CurrentCell = nextCell;
            if(nextGameObjectType == GameObjectType.REWARD)
            {
                Score++;
            }
            if (currentCell != nextCell)
            {   
                currentCell.setGameObject(Game.getBlankGameObject());
            }
        
            return nextCell;
        }

        public int Score { get => score; set => score = value; }

       /* public bool checkPackmanEatPallet()
        {
            PictureBox pic = new PictureBox();
            pic.Image = Game.getGameObjectImage('.');
            if(this.CurrentCell.PictureBox.Bounds.IntersectsWith(pic.Bounds))
            {
                return true;
            }
            return false;
        }
       */
        
    }

    
}
