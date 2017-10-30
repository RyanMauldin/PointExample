namespace PointExample.Common.Interfaces
{
    /// <summary>
    /// A transformation to perform on a point.
    /// </summary>
    public interface ITransformation
    {
        /// <summary>
        /// Method to perform a transformation on a point.
        /// </summary>
        /// <param name="point">The point to perform the transformation on.</param>
        void Transform(IPoint point);
    }
}
