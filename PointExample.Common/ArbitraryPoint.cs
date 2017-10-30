namespace PointExample.Common
{
    /// <summary>
    /// Represents an arbitrary point value.
    /// </summary>
    public class ArbitraryPoint
        : AbstractPoint
    {
        /// <summary>
        /// This field could be custom to this point, which will
        /// differentiate it from a screen point.
        /// </summary>
        public string ArbitaryData => "I am somehow custom";

        /// <summary>
        /// The specific constructor that must be used.
        /// </summary>
        /// <param name="x">The X axis for the point model data.</param>
        /// <param name="y">The Y axis for the point model data.</param>
        public ArbitraryPoint(int x, int y)
            : base(x, y)
        {

        }
    }
}
