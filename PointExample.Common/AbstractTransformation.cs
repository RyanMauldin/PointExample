using PointExample.Common.Interfaces;

namespace PointExample.Common
{
    /// <summary>
    /// Abstract or Base class for all point transformations.
    /// </summary>
    public abstract class AbstractTransformation
        : ITransformation
    {
        /// <summary>
        /// Method to perform a transformation on a point.
        /// </summary>
        /// <param name="point">The point to perform the transformation on.</param>
        public abstract void Transform(IPoint point);
    }
}
