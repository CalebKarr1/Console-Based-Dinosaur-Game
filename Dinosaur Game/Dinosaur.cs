using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaur_Game
{
    internal class Dinosaur
    {
        private int xPos;
        private double yPos;
        private double yVel;
        private int frame = 0;
        private string[] dinosaur = {
            "         ___ ",
            "        / '< ",
            "'___.--' /<  ",
            " '-._, )/    ",
            "    -'/      ",
            "      ^      "
            };
        private string[] dinosaur2 = {
            "         ___ ",
            "        / '< ",
            "'___.--' /<  ",
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
                yVel-=0.2;
                

            }
            for (int i = 0; i < dinosaur.Length; i++)
            {

                for (int e = 0; e < 13; e++)
                {
                    Console.SetCursorPosition(this.xPos + e, y - 5 + i - (int)this.yPos);
                    if ((frame < 5 ? dinosaur[i][e] : dinosaur2[i][e]) != ' ')
                    {
                        Console.Write(" ");
                    }

                }

            }
            yPos += yVel;
            if (yPos < 0)
            {
                yPos = 0;
            }
            frame++;
            frame = frame > 10 ? 0 : frame;
            debug("yVel", yVel);
            for (int i = 0; i < dinosaur.Length; i++)
            {
                
                for (int e = 0; e < 13; e++)
                {
                    Console.SetCursorPosition(this.xPos + e, y - 5 + i - (int)this.yPos);
                    if ((frame < 5 ? dinosaur[i][e] : dinosaur2[i][e]) != ' ')
                    {
                        Console.Write((frame < 5 ? dinosaur[i][e] : dinosaur2[i][e]));
                    }
                    else
                    {
                        
                    }

                }
                //Console.WriteLine(frame<5?dinosaur[i]: dinosaur2[i]);
            }
            
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
