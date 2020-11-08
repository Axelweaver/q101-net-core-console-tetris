using Q101.ConsoleNetCoreTetris.Application.Configurations.Abstract;
using Q101.ConsoleNetCoreTetris.Application.Enums;

namespace Q101.ConsoleNetCoreTetris.Application.Fields
{
    /// <summary>
    /// Elements of game field
    /// </summary>
    public class FieldElements
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem Wall { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem Floor { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem LeftTopCorner { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem RightTopCorner { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem LeftBottomCorner { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldElementItem RightBottomCorner { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="config"></param>
        public FieldElements(IApplicationConfig config)
        {
            Wall = GetElement(FieldElementTypes.Wall, 
                config.FieldSettings.Wall);

            Floor = GetElement(FieldElementTypes.Floor, 
                config.FieldSettings.Floor);

            LeftTopCorner = GetElement(FieldElementTypes.LeftTopCorner, 
                config.FieldSettings.LeftTopCorner);

            RightTopCorner = GetElement(FieldElementTypes.RightTopCorner, 
                config.FieldSettings.RightTopCorner);

            LeftBottomCorner = GetElement(FieldElementTypes.LeftBottomCorner, 
                config.FieldSettings.LeftBottomCorner);

            RightBottomCorner = GetElement(FieldElementTypes.RightBottomCorner, 
                config.FieldSettings.RightBottomCorner);

        }

        private FieldElementItem GetElement(FieldElementTypes type, string charValue)
        {
            var element = new FieldElementItem(type, charValue);

            return element;
        }
    }
}
