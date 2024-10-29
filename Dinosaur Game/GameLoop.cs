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
            Thread loop = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(50);
                    LoopFunction();
                    
                }
            });
            loop.Start();

            
        }
       
        
       
    }
}
