using System.Collections.Concurrent;
using PointExample.Common.Interfaces;

namespace PointExample.Common.Factories
{
    /// <summary>
    /// This is a factory for screen points, utilizing the Factory Method pattern.
    /// </summary>
    public class ScreenPointFactory
    {
        /// <summary>
        /// This is the transformation to apply on point creation.
        /// </summary>
        protected readonly ITransformation Transformation;

        /// <summary>
        /// This is a threadsafe queue data structure to hold points
        /// created in advance to speed up random instantiation. Having
        /// this inside a factory is known as a Object Pool Pattern.
        /// </summary>
        protected readonly ConcurrentQueue<ScreenPoint> ObjectPoolPoints;

        /// <summary>
        /// The specific constructor that must be used.
        /// </summary>
        /// <param name="transformation">The tranformation.</param>
        public ScreenPointFactory(ITransformation transformation)
        {
            Transformation = transformation;
            ObjectPoolPoints = new ConcurrentQueue<ScreenPoint>();

            // Add initial object pool points.
            AddPoints(1000);
        }

        /// <summary>
        /// This is the factory method.
        /// </summary>
        /// <param name="x">The x value to use for the point.</param>
        /// <param name="y">The y value to use for the point.</param>
        /// <returns>An instantiated screen point.</returns>
        public IPoint Create(int x, int y)
        {
            try
            {
                ScreenPoint point;
                if (ObjectPoolPoints.TryDequeue(out point))
                {
                    // Try to use object pool pattern.
                    point.X = x;
                    point.Y = y;
                }
                else
                {
                    // Instantiate an object to return asap.
                    point = new ScreenPoint(x, y);
                }

                // Apply point transformation.
                Transformation.Transform(point);

                return point;
            }
            finally
            {
                // See if more points should be added in bulk.
                // Add them here or create a scheduler object.
                if (ObjectPoolPoints.Count <= 100)
                    AddPoints(1000);
            }
        }

        /// <summary>
        /// Add more object pool points to the queue or create
        /// a scheduler object and pass on the information.
        /// </summary>
        /// <param name="count">The number of potential points to add.</param>
        private void AddPoints(int count)
        {
            for (var i = 0; i < count; i++)
                ObjectPoolPoints.Enqueue(new ScreenPoint(0, 0));
        }
    }
}
