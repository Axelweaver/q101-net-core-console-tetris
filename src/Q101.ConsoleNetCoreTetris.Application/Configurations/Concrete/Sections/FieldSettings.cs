namespace Q101.ConsoleNetCoreTetris.Application.Configurations.Concrete.Sections
{
    /// <summary>
    /// FieldSettings
    /// </summary>
    public class FieldSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public int FieldTop { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int FieldLeft { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int FieldHeight { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int FieldWidth { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Wall { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Floor { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string LeftTopCorner { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RightTopCorner { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string LeftBottomCorner { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RightBottomCorner { get; private set; }
    }
}
