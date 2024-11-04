using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaur_Game
{
    internal class Dinosaur
    {
        private int xPos;
        private double yPos;
        private double yVel;
        private string[] dinosaur = {
            "         ___ ",
            "        /   \\",
            "'___.--' /'  ",
            " '-._, )/    ",
            "    -'/      ",
            "      ^      "
            };
        private string[] dinosaur2 = {
            "         ___ ",
            "        /   \\",
            "'___.--' /'  ",
            " '-._, )/    ",
            "     /^.     ",
            "     '       "
            };



        public Dinosaur(int xPos) { 
            this.xPos = xPos;
            this.yPos = 0;
        }
        public void Jump()
        {
            if (yPos == 0)
            {
                yVel = 2;
            }
            
        }
        public void draw(int y)
        {

            //for(int i = 0; i< Console.WindowHeight;i++)
            //{
            //    Console.SetCursorPosition(xPos, y);
            //    Console.Write(new string(' ', 6));
            //}

            
            
            if (yPos > 0)
            {
                yVel-=0.1;
                for (int i = 0; i < dinosaur.Length; i++)
                {
                    Console.SetCursorPosition(this.xPos, y - 5 + i - (int)this.yPos / 3);
                    Console.WriteLine(new string(' ', 13));
                }

            }
            yPos += yVel;
            if (yPos < 0)
            {
                yPos = 0;
            }
           
            for (int i = 0; i < dinosaur.Length; i++)
            {
                Console.SetCursorPosition(this.xPos, y - 5+i-(int)this.yPos/3);
                Console.WriteLine(dinosaur[i]);
            }
            debug("yVel", yVel);
        }
        public static void debug(string label, object str)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("                                                       ");
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(label + ": " + str + "   ");
        }
    }
}
