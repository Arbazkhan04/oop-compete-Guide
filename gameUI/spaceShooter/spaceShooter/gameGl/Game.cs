using PackmanGui.GameGL;
using PacMan.GameGL;
using spaceShooter.gameGl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackmanGui.GameGL
{
    public class Game
    {

        private static GamePlayer player;

        public static GamePlayer getPlayer()
        {
            return player;
        }

        public static void setPlayer(GamePlayer gamePlayer)
        {
            player = gamePlayer;
        }


        public static Image getImageForBullet(GameDirection direction)
        {
            Image img = spaceShooter.Resource1.simplebox;
            if (direction == GameDirection.Left)
            {
                img = spaceShooter.Resource1.leftBullet;
            }
            else if (direction == GameDirection.Right)
            {
                img = spaceShooter.Resource1.upBullet; //right bullet anme not changed
            }
            else if (direction == GameDirection.Up)
            {
                img = spaceShooter.Resource1.fire;

            }
            else if (direction == GameDirection.Down)
            {
                img = spaceShooter.Resource1.downBullet;
            }
            return img;
        }

        public static Image getImageForPlayer(GameDirection direction)
        {
            Image img = spaceShooter.Resource1.simplebox;
            if (direction == GameDirection.Left)
            {
                img = spaceShooter.Resource1.leftPlayer;
            }
            else if (direction == GameDirection.Right)
            {
                img = spaceShooter.Resource1.rightPlayer;
            }
            else if (direction == GameDirection.Up)
            {
                img = spaceShooter.Resource1.player;

            }
            else if (direction == GameDirection.Down)
            {
                img = spaceShooter.Resource1.downPlayer;
            }
            return img;
        }

        public static  GameObject  getBlankGameObject()
        {
            Image img = spaceShooter.Resource1.simplebox;

            GameObject gameObject = new GameObject(GameObjectType.NONE, img);

            return gameObject;
        }
        public static Image getBulletImage()
        {
            Image img = spaceShooter.Resource1.fire;
            return img;
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
