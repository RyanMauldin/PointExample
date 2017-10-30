using PointExample.Common.Interfaces;

namespace PointExample.Common
{
    /// <summary>
    /// The transformation to perform on arbitrary points.
    /// </summary>
    public class ArbitraryTransformation
        : AbstractTransformation
    {
        /// <summary>
        /// The X axis scale modifier.
        /// </summary>
        public int XScaleModifier => 1;

        /// <summary>
        /// The Y axis scale modifier.
        /// </summary>
        public int YScaleModifier => 2;

        /// <summary>
        /// Method to perform a transformation on a point.
        /// </summary>
        /// <param name="point">The point to perform the transformation on.</param>
        public override void Transform(IPoint point)
        {
            point.X *= XScaleModifier;
            point.Y *= YScaleModifier;
        }
    }
}
