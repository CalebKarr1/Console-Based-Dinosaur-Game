using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Dinosaur_Game
{
    internal class Program
    {   
        static Random random = new Random();
        static int score = 0;
        static string[] groundBumps = { ",-=+-,", "_-+=──_", "──", "─+=__+─=-" };
        
        static string getGround()
        {
            string ground = "";
            Random random = new Random();
            while (ground.Length < Console.WindowWidth)
            {
                if (random.Next(4) != 0)
                {
                    ground += new string('_', random.Next(10, 20));

                }
                else
                {
                    ground += groundBumps[random.Next(0, groundBumps.Length)];
                }
            }
            return ground;
        }
        static void Main(string[] args)
        {
            char i = 'a';
            
            
            string ground = getGround();
            int windowHeight = Console.WindowHeight;
            int windowWidth = Console.WindowHeight;
            Dinosaur dinosaur = new Dinosaur(10);
            Console.CursorVisible = false;
            Obstacle.setCoolDown();
            Obstacle.addObstacle(obstacle.CACTUS);
            GameLoop loop = new GameLoop(() =>
            {
                
                if(Console.WindowHeight!= windowHeight)
                {
                    Console.Clear();
                    windowHeight = Console.WindowHeight;

                }
                if (Console.WindowWidth != windowWidth)
                {
                    Console.Clear();
                    windowWidth = Console.WindowWidth;
                }
                Console.SetCursorPosition(0, windowHeight / 2-1);
                Console.Write(ground.Substring(0, windowWidth));

                ground = ground.Substring(1);
                if (ground.Length < windowWidth * 1.5)
                {
                    ground += getGround();
                }
                if (Obstacle.coolDown < 0)
                {
                    Obstacle.addObstacle(obstacle.CACTUS);
                }

                Obstacle.drawObstacles(windowHeight / 2 - 1);
                dinosaur.draw(windowHeight / 2 - 1);
            });
            loop.Run();
            Thread inputThread = new Thread(() =>
            {
                while (true)
                {
                    i = Console.ReadKey(true).KeyChar;
                }
            }); 
            inputThread.Start();
            
        }

    }
}
