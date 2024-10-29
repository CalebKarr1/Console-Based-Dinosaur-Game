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
        public static List<Obstacle> obstacles;
        public static void addObstacle()
        {
            obstacle type = random.Next(0,2)==0?obstacle.BIRD:obstacle.CACTUS;
            obstacles.Add(new Obstacle(type));
            
        }
        public static void addObstacle(obstacle type)
        {
            obstacles.Add(new Obstacle(type));
        }
        public static int coolDown;
        public static void setCoolDown(int coolDown=20)
        {
            Obstacle.coolDown = coolDown;
        }
        
        private int position = Console.WindowWidth+6;
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

        private string[] getBird()
        {

        }
        public Obstacle(obstacle type)
        {
            this.type = type;

            this.shape = getShape();
        }
        private string[] getShape()
        {
            if (this.type == obstacle.CACTUS)
                return getCactus();
            else
                return getBird();
        }
    }
}
