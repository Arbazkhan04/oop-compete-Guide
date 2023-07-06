using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public class HorizantalGhost:Ghost
    {
        public HorizantalGhost(char displayCharacter, GameCell cell) : base(displayCharacter, cell)
        {
        }

        public  override GameCell move() //move ghost horizantal
        {
            if(this.CurrentCell.)
            return this.CurrentCell.nextCell(GameDirection.Right);//methd flop because it will only move toward right
        }
    }
}
