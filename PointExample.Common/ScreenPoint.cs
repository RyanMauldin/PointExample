namespace PointExample.Common
{
    /// <summary>
    /// Represents a screen point value.
    /// </summary>
    public class ScreenPoint
        : AbstractPoint
    {
        /// <summary>
        /// The specific constructor that must be used.
        /// </summary>
        /// <param name="x">The X axis for the point model data.</param>
        /// <param name="y">The Y axis for the point model data.</param>
        public ScreenPoint(int x, int y)
            : base(x, y)
        {

        }
    }
}
