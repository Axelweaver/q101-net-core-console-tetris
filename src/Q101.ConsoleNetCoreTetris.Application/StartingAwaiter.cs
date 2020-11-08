using System;
using Q101.ConsoleNetCoreTetris.Application.Events;

namespace Q101.ConsoleNetCoreTetris.Application
{
    class StartingAwaiter
    {
        private readonly KeyPressEventHandler _keyPressEventHandler;

        public StartingAwaiter(KeyPressEventHandler keyPressEventHandler)
        {
            _keyPressEventHandler = keyPressEventHandler;
        }

        public void Show()
        {
            var startTime = DateTime.Now;

            ConsoleKeyInfo consoleKey = new ConsoleKeyInfo();

            _keyPressEventHandler.KeyPress += keyInfo => consoleKey = keyInfo;

            while (consoleKey.Key != ConsoleKey.Enter)
            {

                Console.SetCursorPosition(0, 22);

                var dateDiff = DateTime.Now - startTime;

                if (dateDiff.Milliseconds == 0)
                {
                    var enterMessage = dateDiff.Seconds % 2 == 0
                        ? "            "
                        : "Press Enter";

                    Console.SetCursorPosition(48, 12);

                    Console.Write(enterMessage);

                }
            }
        }
    }
}
