using System;
using Q101.ConsoleNetCoreTetris.Application.Configurations.Abstract;

namespace Q101.ConsoleNetCoreTetris.Application.Fields
{
    /// <summary>
    /// Game Field
    /// </summary>
    public class Field
    {
        private readonly int _height;

        private readonly int _width;

        private readonly int _top;

        private readonly int _left;

        private readonly FieldElements _fieldElements;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="fieldElements"></param>
        public Field(IApplicationConfig config, FieldElements fieldElements)
        {
            _height = config.FieldSettings.FieldHeight;

            _width = config.FieldSettings.FieldWidth;

            _top = config.FieldSettings.FieldTop;

            _left = config.FieldSettings.FieldLeft;

            _fieldElements = fieldElements;
        }

        public void DrawField()
        {
            Console.SetCursorPosition(_left - 1, _top - 1);
            Console.WriteLine(
                "{0}{1}{2}",
                _fieldElements.LeftTopCorner.Char,
                _fieldElements.Floor.Char.PadLeft(_width, _fieldElements.Floor.Char[0]),
                _fieldElements.RightTopCorner.Char);

            for (int i = 0; i < _height; i++)
            {
                Console.SetCursorPosition(_left - 1, _top + i);

                Console.WriteLine(
                    "{0}{1}{0}",
                    _fieldElements.Wall.Char,
                    " ".PadRight(_width));
            }

            Console.SetCursorPosition(_left - 1, _top + _height);

            Console.WriteLine(
                "{0}{1}{2}",
                _fieldElements.LeftBottomCorner.Char,
                _fieldElements.Floor.Char.PadRight(_width, _fieldElements.Floor.Char[0]),
                _fieldElements.RightBottomCorner.Char);

        }
    }
}
