namespace PointExample.Common.Interfaces
{
    /// <summary>
    /// Interface to represent a point.
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// The X axis for the point model data.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// The Y axis for the point model data.
        /// </summary>
        int Y { get; set; }
    }
}
