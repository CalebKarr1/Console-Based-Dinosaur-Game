using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Dinosaur_Game
{
    internal class GameLoop
    {
        private Action LoopFunction;
        public GameLoop(Action run) {
            LoopFunction = run;
        }

        public void Run()
        {
            double speed = 50;
            Thread loop = new Thread(() =>
            {
                while (true)
                {
                    int score = 0;
                    Program.calculateScore(out score);
                    speed = (10.0 * Math.Pow(0.5, score / 100000))+5;
                    Program.printInfo(3, "speed", speed);
                    Thread.Sleep((int)speed);
                    LoopFunction();
                    
                }
            });
            loop.Start();

            
        }
       
        
       
    }
}
