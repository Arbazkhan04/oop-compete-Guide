using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PacMan.BL
{
    public class gameObject
    {
         char displayCharacter;
         GameCell currentCell;
         GameObjectType gameObjectType;
        public gameObject(GameObjectType type,char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
            this.gameObjectType = type;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {
            if(displayCharacter=='|' || displayCharacter=='%'||displayCharacter=='#')
            {
                return GameObjectType.Wall;
            }
            if (displayCharacter=='.')
            {
                return GameObjectType.Reward;
            }
            return GameObjectType.None;
        }
     

        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }

        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }

        public GameCell CurrentCell {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.CurrentGameObject = this; 
            }

        }
    }
}

