using PointExample.Common.Interfaces;

namespace PointExample.Common
{
    /// <summary>
    /// Abstract or Base class for all points.
    /// </summary>
    public abstract class AbstractPoint
        : IPoint
    {
        /// <summary>
        /// The X axis for the point model data.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The Y axis for the point model data.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// The specific constructor that must be used.
        /// </summary>
        /// <param name="x">The X axis for the point model data.</param>
        /// <param name="y">The Y axis for the point model data.</param>
        protected AbstractPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
