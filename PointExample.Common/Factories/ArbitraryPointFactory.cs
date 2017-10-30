using PointExample.Common.Interfaces;

namespace PointExample.Common.Factories
{
    /// <summary>
    /// This is a factory for arbitrary points, utilizing the Factory Method pattern.
    /// </summary>
    public class ArbitraryPointFactory
    {
        /// <summary>
        /// This is the transformation to apply on point creation.
        /// </summary>
        protected readonly ITransformation Transformation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transformation">The tranformation.</param>
        public ArbitraryPointFactory(
            ITransformation transformation)
        {
            Transformation = transformation;
        }

        /// <summary>
        /// This is the factory method.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y">The y value to use for the point.</param>
        /// <returns>An instantiated arbitrary point.</returns>
        public IPoint Create(int x, int y)
        {
            var point = new ArbitraryPoint(x, y);

            // Apply point transformation.
            Transformation.Transform(point);

            return point;
        }
    }
}
