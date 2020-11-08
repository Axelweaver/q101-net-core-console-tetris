using System;
using Q101.ConsoleNetCoreTetris.Application.Fields;

namespace Q101.ConsoleNetCoreTetris.Application.Games
{
    /// <summary>
    /// Game
    /// </summary>
    public class TetrisGame
    {
        private readonly Field _field;

        public TetrisGame(Field field)
        {
            _field = field;
        }

        public void Start()
        {
            Console.Clear();

            _field.DrawField();
        }
    }
}
