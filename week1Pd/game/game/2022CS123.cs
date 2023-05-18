using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using EZInput;
using System.Globalization;
using System.Runtime.InteropServices;

namespace game
{
    internal class Program
    {
        static int score = 0;
       static char[,] hel2 = new char[2, 9] {
                { ' ', ' ', ' ', '_', '_', '_', ' ', ' ', ' '},
                   { '}', '-', '|', '_', '_', '_', '|', '-', '>'}//moving toward right
            };
       static  char[,] leftHel1 = new char[2, 9] {
                { '{', '-', '|', '_', '_', '_', '|', '-', '<'},
                       { ' ', ' ', ' ', '_', '_', '_', ' ', ' ', ' '}
            }; // moving toward left
        static void Main(string[] args)
        {

            char[,] map = new char[22, 121];
            storeMapIntoAnArray(map);
            storeAMapIntoFile(map);
        
            printMaze(map);

            //player cooordinates
            int playerX = 10;
            int playerY = 4;
            playerLocation Monochoki = new playerLocation(playerX,playerY);
            printRightPlayer(Monochoki);

           // Console.SetCursorPosition(palyerY, playerX);
           // Console.Write("P");
            bool isGameRuning = true;
            while (isGameRuning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePlayerRight(map, Monochoki);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePlayerLeft(map, Monochoki);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movePlayerUp(map, Monochoki);
                }
                if(Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePlayerDown(map, Monochoki);
                }
            }
            Console.ReadKey();



        }
        static void movePlayerDown(char[,] map ,playerLocation monochoki)
        {
            if (map[monochoki.playerX +4, monochoki.playerY] == ' '|| map[monochoki.playerX + 4, monochoki.playerY] != '*')
            {
                ereasePlayer(monochoki.playerX, monochoki.playerY);
                monochoki.playerX = monochoki.playerX +1;
                printLeftPlayer(monochoki.playerX, monochoki.playerY);

            }
        }
        static void movePlayerUp(char[,] map,playerLocation monochoki)
        {
            if (map[monochoki.playerX-2, monochoki.playerY ] == ' '|| map[monochoki.playerX -2, monochoki.playerY] != '*')
            {
                ereasePlayer(monochoki.playerX, monochoki.playerY);
                monochoki.playerX = monochoki.playerX - 1;
                printLeftPlayer(monochoki.playerX, monochoki.playerY);

            }
        }
        static void movePlayerLeft( char [,] map,playerLocation monochoki)
        {

            if (map[monochoki.playerX, monochoki.playerY - 1] == ' '|| map[monochoki.playerX, monochoki.playerY-1] != '*')
            {
                ereasePlayer(monochoki.playerX, monochoki.playerY);
                monochoki.playerY = monochoki.playerY - 1;
                printLeftPlayer(monochoki.playerX, monochoki.playerY);

            }
        }

        static void printLeftPlayer(int x,int y)
        {

            Console.SetCursorPosition(y, x);
            for (int j = 0; j < 2; j++)
            {
                for (int i = 8; i >= 0; i--)
                {
                    Console.Write(leftHel1[j,i]);
                }
                Console.SetCursorPosition(y, x - 1);
            }
        }

        static void ereaseLeftPlayer(int x,int y)
        {
            Console.SetCursorPosition(y, x);
            for (int row = 0; row < 2; row++)
            {
                for (int i = 8; i >= 0; i--)
                {
                    char empty = leftHel1[row,i];
                    empty = ' ';
                    Console.Write(empty);
                }
                Console.SetCursorPosition(y, x - 1);
            }
        }

         static void printRightPlayer(playerLocation monochoki )
        {
            Console.SetCursorPosition(monochoki.playerY,monochoki.playerX);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(hel2[i,j]);
                }
                Console.SetCursorPosition(monochoki.playerY, monochoki.playerX+1); ;
            }
        }

        static void ereasePlayer(int x,int y)
        {
            Console.SetCursorPosition(y,x);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char empty = hel2[i, j];
                    empty = ' ';
                    Console.Write(empty);
                }
                Console.SetCursorPosition(y,x+1);
            }
        }

        static void movePlayerRight(char[,] map,playerLocation monochoki)
        {
            if (map[monochoki.playerX, monochoki.playerY + 9] == ' ' || map[monochoki.playerX, monochoki.playerY + 9]!='*')
            {
                ereasePlayer(monochoki.playerX, monochoki.playerY);
                monochoki.playerY = monochoki.playerY + 1;
                printRightPlayer(monochoki);//it may create an error
            }
        }
      

        static void storeMapIntoAnArray(char[,] map)
        {
            for (int i = 0; i <= 120; i++)
            {
                map[0, i] = '*';
                map[21, i] = '*';
            }
            for (int i = 1; i < 21; i++)
            {
                map[i, 0] = '*';
                map[i, 120] = '*';
                for (int j = 1; j < 120; j++)
                {
                    map[i, j] = ' ';
                }
            }
        }
        static void storeAMapIntoFile(char[,] map)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\game\\game\\map.txt";
            StreamWriter file = new StreamWriter(path, true);

            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 121; j++)
                {
                    file.Write(map[i, j]);
                }
                Console.WriteLine();
            }
            file.Flush();
            file.Close();

        }


        static void printMaze(char[,] map)
        {
            int x = 0, y = 0;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 22; i++)//row
            {
                for (int j = 0; j < 121; j++)//col
                {
                    Console.Write(map[i, j]);
                  
                }
                
               Console.WriteLine();
            }
        }

    }
}
