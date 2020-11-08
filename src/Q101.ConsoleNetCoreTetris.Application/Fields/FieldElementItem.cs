using Q101.ConsoleNetCoreTetris.Application.Enums;

namespace Q101.ConsoleNetCoreTetris.Application.Fields
{
    /// <summary>
    /// Element of game field
    /// </summary>
    public class FieldElementItem
    {
        /// <summary>
        /// Type
        /// </summary>
        public FieldElementTypes Type { get; }

        /// <summary>
        /// Char
        /// </summary>
        public string Char { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public FieldElementItem(FieldElementTypes type, string value)
        {
            Type = type;
            Char = value;
        }
    }
}
