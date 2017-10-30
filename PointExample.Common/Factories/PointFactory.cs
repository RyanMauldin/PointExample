using PointExample.Common.Interfaces;

namespace PointExample.Common.Factories
{
    /// <summary>
    /// This is an abstract factory concrete for all related points.
    /// </summary>
    public class PointFactory
        : AbstractPointFactory
    {
        /// <summary>
        /// The screen point factory instance.
        /// </summary>
        protected readonly ScreenPointFactory ScreenPointFactory;

        /// <summary>
        /// The arbitrary point factory instance.
        /// </summary>
        protected readonly ArbitraryPointFactory ArbitraryPointFactory;

        /// <summary>
        /// The specific constructor that must be used.
        /// </summary>
        /// <param name="screenPointFactory">The screen point factory instance.</param>
        /// <param name="arbitraryPointFactory">The arbitrary point factory instance.</param>
        public PointFactory(
            ScreenPointFactory screenPointFactory,
            ArbitraryPointFactory arbitraryPointFactory)
        {
            ScreenPointFactory = screenPointFactory;
            ArbitraryPointFactory = arbitraryPointFactory;
        }

        /// <summary>
        /// This is the factory method for screen points.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y"></param>
        /// <returns>An instantiated screen point.</returns>
        public override IPoint CreateScreenPoint(int x, int y)
        {
            return ScreenPointFactory.Create(x, y);
        }

        /// <summary>
        /// This is the factory method for arbitrary points.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y">The y value to use for the point.</param>
        /// <returns>An instantiated arbitrary point.</returns>
        public override IPoint CreateArbitraryPoint(int x, int y)
        {
            return ArbitraryPointFactory.Create(x, y);
        }
    }
}
