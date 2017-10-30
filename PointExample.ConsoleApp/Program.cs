using System;
using PointExample.Common.Factories;
using PointExample.Common.Interfaces;
using PointExample.ConsoleApp.App_Start;

namespace PointExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup our DI
            var serviceProvider = IocConfig.ConfigureIocService();

            // Resolve a Point Factory
            var pointFactory = (AbstractPointFactory)serviceProvider.GetService(typeof(PointFactory));

            Console.WriteLine("Displaying points:");
            Console.WriteLine();

            // Create and Display two different types of points.
            var point1 = pointFactory.CreateScreenPoint(1, 2);
            var point2 = pointFactory.CreateArbitraryPoint(1, 2);
            DisplayPoint(point1);
            DisplayPoint(point2);

            // Wait for any key.
            Console.WriteLine();
            Console.Write("Press any key to exit: ");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Display a point on the Console.
        /// </summary>
        /// <param name="point">The point to display.</param>
        private static void DisplayPoint(IPoint point)
        {
            Console.WriteLine(string.Format("x: {0}, y: {1}", point.X, point.Y));
        }
    }
}
