namespace T2
{
    /// <summary>
    /// Action Figur
    /// </summary>
    public class ActionFigure
    {
        /// <summary>
        /// Enum Directiontyp
        /// </summary>
        public enum DirectionTyp
        {
            Left,
            Rigth,
            Up,
            Down
        }

        /// <summary>
        /// DirectionTyp
        /// </summary>
        public DirectionTyp Direction { get; set; }

        /// <summary>
        /// Aktive oder nicht
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Position X
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Position Y
        /// </summary>
        public int PositionY { get; set; }

        /// <summary>
        /// Geschwindigkeit
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        public ActionFigure()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="direction">Richtung</param>
        public ActionFigure(DirectionTyp direction)
        {
            Direction = direction;
        }

        /// <summary>
        /// Spielen
        /// </summary>
        public void Play()
        {

        }

    }
}
