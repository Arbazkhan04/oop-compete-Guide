using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using EZInput;
using System.Globalization;

namespace game
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            char[,] map = new char[22, 121];
            storeMapIntoAnArray(map);
            storeAMapIntoFile(map);
        
            printMaze(map);

            //player cooordinates
            int playerX =10;
            int palyerY = 4;

            Console.SetCursorPosition(palyerY, playerX);
            Console.Write("P");
            bool isGameRuning = true;
            while (isGameRuning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePlayerRight(map, ref playerX, ref palyerY);
                }
            }
            Console.ReadKey();



        }
        static void movePlayerRight(char[,] map,ref int playerX,ref int playerY)
        {
            if (map[playerX, playerY + 1] == ' ' || map[playerX, playerY + 1] == ' ')
            {
                map[playerX, playerY] = ' ';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write(" ");
                playerY = playerY + 1;
               
                Console.SetCursorPosition(playerY, playerX);
                map[playerX, playerY] = 'P';
                Console.Write("P");

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
