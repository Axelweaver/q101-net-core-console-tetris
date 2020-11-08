using System;
using Q101.ConsoleNetCoreTetris.Application.Events;
using Q101.ConsoleNetCoreTetris.Application.Games;

namespace Q101.ConsoleNetCoreTetris.Application
{
    /// <summary>
    /// Startup of application
    /// </summary>
    class Startup
    {
        private readonly KeyPressEventHandler _keyPressEventHandler;

        private readonly StartingAwaiter _startingAwaiter;

        private readonly TetrisGame _tetrisGame;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="keyPressEventHandler"></param>
        /// <param name="startingAwaiter"></param>
        /// <param name="tetrisGame"></param>
        public Startup(KeyPressEventHandler keyPressEventHandler, 
                       StartingAwaiter startingAwaiter,
                       TetrisGame tetrisGame)
        {
            _keyPressEventHandler = keyPressEventHandler;
            _startingAwaiter = startingAwaiter;
            _tetrisGame = tetrisGame;
        }

        public void Run()
        {
            _startingAwaiter.Show();

            _tetrisGame.Start();

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
