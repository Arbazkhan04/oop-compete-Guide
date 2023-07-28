using PackmanGui.GameGL;
using PacMan.GameGL;

namespace spaceShooter.gameGl
{
    public class SmartEnemy : gameEnemy
    {
        public SmartEnemy(Image img, GameCell currentCell, GameDirection gameDirection) : base(img, currentCell, gameDirection)
        {
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;

            GameCell playerCell = Game.getPlayer().CurrentCell;

            int dx = currentCell.X - playerCell.X;
            int dy = currentCell.Y - playerCell.Y;

            int upDistance = Math.Abs(dx - 1) + Math.Abs(dy);
            int downDistance = Math.Abs(dx + 1) + Math.Abs(dy);
            int leftDistance = Math.Abs(dx) + Math.Abs(dy - 1);
            int rightDistance = Math.Abs(dx) + Math.Abs(dy + 1);

            GameDirection direction;
            int minDistance = Math.Min(upDistance, Math.Min(downDistance, Math.Min(leftDistance, rightDistance)));
            if (minDistance == upDistance)
            {
                direction = GameDirection.Up;
            }
            else if (minDistance == downDistance)
            {
                direction = GameDirection.Down;
            }
            else if (minDistance == leftDistance)
            {
                direction = GameDirection.Left;
            }
            else
            {
                direction = GameDirection.Right;
            }

            GameCell nextCell = currentCell.nextCell(direction);
            GameObjectType nextGameObjectType = nextCell.CurrentGameObject.GameObjectType;

            if (nextCell != currentCell && nextGameObjectType != GameObjectType.WALL && nextGameObjectType != GameObjectType.ENEMY)
            {
                gameDirection = direction;
                currentCell.setGameObject(Game.getBlankGameObject());
                this.CurrentCell = nextCell;
                currentCell = nextCell;
            }

            return currentCell;
        }




    }
}
