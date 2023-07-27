using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackmanGui.GameGL
{
    public class Game
    {
        public static  GameObject  getBlankGameObject()
        {
            Image img = spaceShooter.Resource1.simplebox;
            GameObject gameObject = new GameObject(GameObjectType.NONE, img);

            return gameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = spaceShooter.Resource1.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = spaceShooter.Resource1.vertical;
            }

            if (displayCharacter == '#')
            {
                img = spaceShooter.Resource1.horizontal;
            }

            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = spaceShooter.Resource1.player;
            }
            if (displayCharacter == 'h'|| displayCharacter == 'h' )

            {
                img = spaceShooter.Resource1.monster; 
            }

            if(displayCharacter == 'v' || displayCharacter == 'V')
            {
                img = spaceShooter.Resource1.monster;
            }
            if (displayCharacter == 'r' || displayCharacter == 'R')
            {
                img = spaceShooter.Resource1.monster;
            }

            return img;
        }
    }
}
