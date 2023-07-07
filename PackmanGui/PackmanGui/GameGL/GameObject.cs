using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GameGL
{
    class GameObject
    {
        char displayCharacter;
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image img;
        public GameObject(GameObjectType type, Image img)
        {
            this.img = img;
            this.gameObjectType = type;  
        }

        public static GameObjectType getGameObjectType(char displayCharacter) { 

            if (displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#') {
                return GameObjectType.WALL;
            }

            if (displayCharacter == '.') {
                return GameObjectType.REWARD;
            }

            return GameObjectType.NONE;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            if(displayCharacter=='#')
            {
                return PackmanGui.Properties.Resources.horizontal;
            }
            return PackmanGui.Properties.Resources.horizontal;
        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }

        public Image Img { get => img; set => img = value; }
        public GameCell CurrentCell { 
            get => currentCell; 
            set  { 
                currentCell = value;
                currentCell.CurrentGameObject = this;
            }
        }
    }
}
