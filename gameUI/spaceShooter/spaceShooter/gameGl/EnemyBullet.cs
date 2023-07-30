using PackmanGui.GameGL;
using PacMan.GameGL;
using System.Collections.Generic;
using System.Drawing;

namespace spaceShooter.gameGl
{
    public abstract class EnemyBullet : GameObject
    {
        public static List<EnemyBullet> enemyBullets = new List<EnemyBullet>();

        public EnemyBullet(Image img, GameCell startCell) : base(GameObjectType.ENEMYBULLET, img)
        {
            this.CurrentCell = startCell;
        }

        public abstract void Move();

        public static void AddEnemyBullet(EnemyBullet bullet)
        {
            enemyBullets.Add(bullet);
        }
    }
}
