using EZInput;
using PackmanGui.GameGL;
using PacMan.GameGL;
using spaceShooter.gameGl;

namespace spaceShooter
{
    public partial class Form1 : Form
    {
        GamePlayer player;
        private List<gameEnemy> enemies = new List<gameEnemy>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("C:\\Users\\Arbaz khan\\OneDrive\\Desktop\\oop-compete-Guide\\gameUI\\spaceShooter\\spaceShooter\\bin\\Debug\\maze1.txt", 30, 68);
            //player
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(10, 10);
            player = new GamePlayer(pacManImage, startCell);


            //horizatal ghsot
            GameCell vCell = grid.getCell(13, 12);
            Image verticleEnmey = Game.getGameObjectImage('v');
            verticleEnemy vEnemies = new verticleEnemy(verticleEnmey, vCell, GameDirection.Down);

            //veritclee ghsot
            GameCell hCell = grid.getCell(1,3);
            Image horizantal = Game.getGameObjectImage('v');
            horizantalEnmey hEnemies = new horizantalEnmey(horizantal, hCell, GameDirection.Left);

            //random ghost
            GameCell rCell = grid.getCell(10, 30);
            Image rImg = Game.getGameObjectImage('r');
            randomEnemy rEnemies = new randomEnemy(rImg, rCell, GameDirection.Down);

            enemies.Add(vEnemies);
            enemies.Add(hEnemies);
            enemies.Add(rEnemies);
            printMaze(grid);
        }

        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                {

                    for (int y = 0; y < grid.Cols; y++)
                    {
                        GameCell cell = grid.getCell(x, y);
                        this.Controls.Add(cell.PictureBox);

                    }

                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
            }

            foreach(gameEnemy enemy in enemies)
            {
                enemy.move();
            }
        }
    }
}