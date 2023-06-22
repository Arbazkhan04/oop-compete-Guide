using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PacMan.BL
{
    public class gameObject
    {
        public char displayCharacter;
        public GameCell currentCell;
        public GameObjectType Enum;
        public gameObject(GameObjectType type,char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
            this.Enum = type;
        }
        public gameObject(char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
        }

       
    }
}
