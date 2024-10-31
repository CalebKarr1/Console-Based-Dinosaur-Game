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
        private string[] dinosaur = {
            "~~~~~~",
            "~~~~~~",
            "~~~~~~",
            "~~~~~~"
            };
        public Dinosaur(int xPos) { 
            this.xPos = xPos;
        }
        public void draw(int y)
        {
            
            for(int i = 0; i < dinosaur.Length; i++)
            {
                Console.SetCursorPosition(this.xPos, y - 4+i);
                Console.WriteLine(dinosaur[i]);
            }
        }
    }
}
