using System;
using System.Drawing;

namespace ITS.Common.SpecialSignEditor.Drawing
{
    // точки, соответствующие сторонам света:
    public class CardinalPoints
    {
        private readonly PointF northPoint;
        private readonly PointF southPoint;
        private readonly PointF westPoint;
        private readonly PointF eastPoint;

        public CardinalPoints(PointF[] points)
        {
            if (points == null)
                throw new NullReferenceException();

            northPoint = points[0];
            southPoint = points[0];
            westPoint = points[0];
            eastPoint = points[0];

            foreach (var point in points)
            {
                if (point.Y < northPoint.Y)
                {
                    northPoint = point;
                }

                if (point.Y > southPoint.Y)
                {
                    southPoint = point;
                }

                if (point.X < westPoint.X)
                {
                    westPoint = point;
                }

                if (point.X > eastPoint.X)
                {
                    eastPoint = point;
                }
            }
        }

        public PointF North => northPoint;

        public PointF South => southPoint;

        public PointF West => westPoint;

        public PointF East => eastPoint;
    }
}
