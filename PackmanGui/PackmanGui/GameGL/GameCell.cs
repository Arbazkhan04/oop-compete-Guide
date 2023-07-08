namespace PacMan.GameGL
{
    public class GameCell
    {
        int x;
        int y;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 20;
        const int height = 20;
        public GameCell(int x, int y,GameGrid grid) {
            this.x = x;
            this.y = y;
            pictureBox = new PictureBox();
            pictureBox.Left = y * width;
            pictureBox.Top = x * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }

        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Img;

        }
        public GameCell nextCell(GameDirection direction)
        {
          
            if (direction == GameDirection.Left) {
                if (this.y > 0) {
                    GameCell ncell = grid.getCell(x, y-1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL) {
                        return ncell;
                    }
                }    
            }

            if (direction == GameDirection.Right)
            {
                if (this.y < grid.Cols-1)
                {
                    GameCell ncell = grid.getCell(this.x, this.y+1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.x > 0)
                {
                    GameCell ncell = grid.getCell(this.x-1, this.y);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.x < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.x+1, this.y);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
    }
}
