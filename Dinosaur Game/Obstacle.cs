using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaur_Game
{
    enum obstacle
    {
        CACTUS,
        BIRD
    }
    internal class Obstacle
    {
        private static Random random = new Random();
        public static List<Obstacle> obstacles = new List<Obstacle>();
        public static void addObstacle()
        {
            obstacle type = random.Next(0,2)==0?obstacle.BIRD:obstacle.CACTUS;
            obstacles.Add(new Obstacle(type));
            
        }
        public static void addObstacle(obstacle type)
        {
            coolDown = 50;
            obstacles.Add(new Obstacle(type));
        }



        public static int coolDown;
        public static void setCoolDown(int coolDown=50)
        {
            Obstacle.coolDown = coolDown;
            
        }
        
        private int position = Console.WindowWidth;
        private obstacle type;
        private string[] shape;
        private string[] getCactus()
        {
            
            switch (random.Next(0, 3))
            {
                case 0:
                    return new string[]
                                {"_   ║ ",
                                 "║ _ ║ ",
                                 "╚═╬═╝ ",
                                 "_╚║_║╝"};
                case 1:
                    return new string[]
                                {"  _   ",
                                 " ╚║   ",
                                 "  ║╝_ ",
                                 "__║_║╝"};
                case 2:
                    return new string[]
                                {"      ",
                                 "      ",
                                 " ║  _ ",
                                 "_║__║╝"};
                default:
                    return new string[] { "______" };

            }
        
        }

        //private string[] getBird()
        //{
        //    return 
        //}
        public Obstacle(obstacle type)
        {
            
            this.type = type;

            this.shape = getShape();
        }

        //turn to out
        private string[] getShape()
        {
            if (this.type == obstacle.CACTUS)
                return getCactus();
            else
                return getCactus();
        }
        public static void clearStage(int y)
        {
            for (int i = 1; i < 5; i++)
                Console.SetCursorPosition(0, y - i);
            Console.Write(new string(' ',Console.WindowWidth));
        }
        public void draw(int y)
        {
            
            this.position--;
            
            if (this.position < 0)
            {
                Obstacle.obstacles.Remove(this);
            }
            
            for(int i = 0; i<this.shape.Length;i++)
            {
                Console.SetCursorPosition(this.position, y+1-(4-i));
                if(position> Console.WindowWidth - 6) 
                    Console.Write(this.shape[i].Substring(0,Console.WindowWidth-position));
                else
                    Console.Write(this.shape[i]);
            }
            

        }
        public static void drawObstacles(int y)
        {
            Obstacle.coolDown--;
            clearStage(y);
            try
            {
                foreach (Obstacle _obstacle in obstacles)
                {
                    _obstacle.draw(y);
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
