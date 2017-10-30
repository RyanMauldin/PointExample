using PointExample.Common.Interfaces;

namespace PointExample.Common.Factories
{
    /// <summary>
    /// This is an abstract factory for all related points.
    /// </summary>
    public abstract class AbstractPointFactory
    {
        /// <summary>
        /// This is the factory method for screen points.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y"></param>
        /// <returns>An instantiated screen point.</returns>
        public abstract IPoint CreateScreenPoint(int x, int y);

        /// <summary>
        /// This is the factory method for arbitrary points.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y">The y value to use for the point.</param>
        /// <returns>An instantiated arbitrary point.</returns>
        public abstract IPoint CreateArbitraryPoint(int x, int y);
    }
}
