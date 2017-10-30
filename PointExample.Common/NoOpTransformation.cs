using PointExample.Common.Interfaces;

namespace PointExample.Common
{
    /// <summary>
    /// The transformation to perform on points that do not need a transformation.
    /// NoOp = No Operation
    /// </summary>
    public class NoOpTransformation
        : AbstractTransformation
    {
        /// <summary>
        /// Method to perform a transformation on a point.
        /// </summary>
        /// <param name="point">The point to perform the transformation on.</param>
        /// <remarks>For this method nothing happens to point data.</remarks>
        public override void Transform(IPoint point)
        {
            // No implementation here.
        }
    }
}
