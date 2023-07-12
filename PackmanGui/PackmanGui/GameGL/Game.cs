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
            Image img = PackmanGui.Properties.Resources.simplebox;
            GameObject gameObject = new GameObject(GameObjectType.NONE, img);

            return gameObject;
        }
      
        public static GameObject getBlankGamePallet()
        {
            Image img = PackmanGui.Properties.Resources.pallet;
            GameObject gameObject = new GameObject(GameObjectType.NONE, img);

            return gameObject;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = PackmanGui.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PackmanGui.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PackmanGui.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PackmanGui.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = PackmanGui.Properties.Resources.pacman_open;
            }
            if (displayCharacter == 'h'|| displayCharacter == 'h' )

            {
                img = PackmanGui.Properties.Resources.ghost_pink; 
            }

            if(displayCharacter == 'v' || displayCharacter == 'V')
            {
                img = PackmanGui.Properties.Resources.ghost_orange;
            }
            if (displayCharacter == 'r' || displayCharacter == 'R')
            {
                img = PackmanGui.Properties.Resources.ghost_fright;
            }

            return img;
        }
    }
}
