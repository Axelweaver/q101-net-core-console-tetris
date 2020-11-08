using System;
using System.Threading.Tasks;

namespace Q101.ConsoleNetCoreTetris.Application.Events
{
    /// <summary>
    /// Key press event handler
    /// </summary>
    public class KeyPressEventHandler
    {
        /// <summary>
        /// Keypress event
        /// </summary>
        public event Action<ConsoleKeyInfo> KeyPress;

        /// <summary>
        /// ctor
        /// </summary>
        public KeyPressEventHandler()
        {
            Task.Run(KeyPressVoid);
        }

        private void KeyPressVoid()
        {
            while (true)
            {
                KeyPress?.Invoke(Console.ReadKey(true));
            }
        }
    }
}
