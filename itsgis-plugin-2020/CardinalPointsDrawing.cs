using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ITS.Common.SpecialSignEditor.Drawing
{
    public static class CardinalPointsDrawing
    {
        public static int TextHeight = 0;
        private static int DistanceCoeff = TextHeight;

        private static readonly Pen Pen = new Pen(Color.Black, 11);
        private static readonly Pen PenWithArrow = new Pen(Pen.Color, Pen.Width)
        {
            StartCap = LineCap.ArrowAnchor,
        };
        private static readonly Pen PenWithArrows = new Pen(Pen.Color, Pen.Width)
        {
            StartCap = LineCap.ArrowAnchor,
            EndCap = LineCap.ArrowAnchor
        };

        //new Font(SpecialSign.FontFamily, text.TextHeight, FontStyle.Bold)
        private static readonly Font Font = new Font("Arial", 100);
        private static readonly SolidBrush Brush = new SolidBrush(Pen.Color);

        // выделяю память один раз, чтобы было меньше работы для сборщика мусора:
        private static PointF start;
        private static PointF end;
        private static PointF left;
        private static PointF right;
        private static PointF up;
        private static PointF low;

        public static void DrawDistanceArrow(Graphics gr, PointF[] fig1Points, PointF[] fig2Points)
        {
            // поиск точек, соответствующих сторонам света:
            CardinalPoints fig1Cps = new CardinalPoints(fig1Points);
            CardinalPoints fig2Cps = new CardinalPoints(fig2Points);

            bool isNorthFig2 = fig1Cps.North.Y > fig2Cps.South.Y;
            bool isSouthFig2 = fig1Cps.South.Y < fig2Cps.North.Y;
            bool isWestFig2 = fig1Cps.West.X > fig2Cps.East.X;
            bool isEastFig2 = fig1Cps.East.X < fig2Cps.West.X;

            if (isNorthFig2)
                DrawNorth(gr, fig1Cps, fig2Cps);
            else if (isSouthFig2)
                DrawSouth(gr, fig1Cps, fig2Cps);
            else if (isWestFig2)
                DrawWest(gr, fig1Cps, fig2Cps);
            else if (isEastFig2)
                DrawEast(gr, fig1Cps, fig2Cps);
        }

        private static void DrawNorth(Graphics gr, CardinalPoints fig1Cps, CardinalPoints fig2Cps)
        {
            start.X = fig1Cps.North.X;
            start.Y = fig1Cps.North.Y;

            end.X = start.X;
            end.Y = fig2Cps.South.Y;

            DrawVerticalLineWithDistanceNear(gr, start, end);

            gr.DrawLine(Pen,
                fig1Cps.West.X, fig1Cps.North.Y,
                fig1Cps.East.X, fig1Cps.North.Y);

            // доводить линию, если не хватает её длины:
            left.X = fig2Cps.West.X > end.X ? end.X : fig2Cps.West.X;
            left.Y = fig2Cps.South.Y;
            // доводить линию, если не хватает её длины:
            right.X = fig2Cps.East.X < end.X ? end.X : fig2Cps.East.X;
            right.Y = left.Y;

            gr.DrawLine(Pen, left, right);
        }

        private static void DrawVerticalLineWithDistanceNear(Graphics gr, PointF lineStart, PointF lineEnd)
        {
            float lineLen = Math.Abs(lineEnd.Y - lineStart.Y);

            if (lineLen > Font.GetHeight())
            {
                gr.DrawLine(PenWithArrows, lineStart, lineEnd);
            }
            else
            {
                gr.DrawLine(Pen, lineStart, lineEnd);
                gr.DrawLine(PenWithArrow,
                    lineStart.X, lineStart.Y,
                    lineStart.X, lineStart.Y - Font.GetHeight());
                gr.DrawLine(PenWithArrow,
                    lineEnd.X, lineEnd.Y,
                    lineEnd.X, lineEnd.Y + Font.GetHeight());
            }

            int distance = (int)Math.Abs(lineEnd.Y - lineStart.Y);
            if (lineLen < Font.GetHeight() / 2f)
            {
                gr.DrawString(distance + " px", Font, Brush,
                    lineStart.X + Font.Size / 4f,
                    lineEnd.Y + Font.GetHeight() / 4f);
            }
            else
            {
                gr.DrawString(distance + " px", Font, Brush,
                    lineStart.X + Font.Size / 4f,
                    (lineStart.Y + lineEnd.Y) / 2f - Font.GetHeight() / 2f);
            }
        }

        private static void DrawSouth(Graphics gr, CardinalPoints fig1Cps, CardinalPoints fig2Cps)
        {
            start.X = fig1Cps.South.X;
            start.Y = fig1Cps.South.Y;

            end.X = start.X;
            end.Y = fig2Cps.North.Y;

            DrawVerticalLineWithDistanceNear(gr, start, end);

            gr.DrawLine(Pen,
                fig1Cps.West.X, fig1Cps.South.Y,
                fig1Cps.East.X, fig1Cps.South.Y);

            // доводить линию, если не хватает её длины:
            left.X = fig2Cps.West.X > end.X ? end.X : fig2Cps.West.X;
            left.Y = fig2Cps.North.Y;
            // доводить линию, если не хватает её длины:
            right.X = fig2Cps.East.X < end.X ? end.X : fig2Cps.East.X;
            right.Y = left.Y;

            gr.DrawLine(Pen, left, right);
        }

        private static void DrawWest(Graphics gr, CardinalPoints fig1Cps, CardinalPoints fig2Cps)
        {
            start.X = fig1Cps.West.X;
            start.Y = fig1Cps.West.Y;

            end.X = fig2Cps.East.X;
            end.Y = start.Y;

            DrawHorizontalLineWithDistanceAbove(gr, start, end);

            gr.DrawLine(Pen,
                fig1Cps.West.X, fig1Cps.North.Y,
                fig1Cps.West.X, fig1Cps.South.Y);

            // доводить линию, если не хватает её длины:
            up.X = fig2Cps.East.X;
            up.Y = fig2Cps.North.Y > end.Y ? end.Y : fig2Cps.North.Y;
            // доводить линию, если не хватает её длины:
            low.X = up.X;
            low.Y = fig2Cps.South.Y < end.Y ? end.Y : fig2Cps.South.Y;

            gr.DrawLine(Pen, up, low);
        }

        private static void DrawHorizontalLineWithDistanceAbove(Graphics gr, PointF lineStart, PointF lineEnd)
        {
            float lineLen = Math.Abs(lineEnd.X - lineStart.X);

            if (lineLen > Font.Size)
            {
                gr.DrawLine(PenWithArrows, lineStart, lineEnd);
            }
            else
            {
                gr.DrawLine(Pen, lineStart, lineEnd);
                gr.DrawLine(PenWithArrow,
                    lineStart.X, lineStart.Y,
                    lineStart.X - Font.Size * 2f, lineStart.Y);
                gr.DrawLine(PenWithArrow,
                    lineEnd.X, lineEnd.Y,
                    lineEnd.X + Font.Size * 2f, lineEnd.Y);
            }

            string distanceStr = (int)Math.Abs(lineEnd.X - lineStart.X) + " px";
            if (distanceStr.Length * Font.Size / 3f > lineLen)
            {
                gr.DrawString(distanceStr, Font, Brush,
                    lineEnd.X + Font.Size / 3f,
                    lineStart.Y - Font.GetHeight());
            }
            else
            {
                gr.DrawString(distanceStr, Font, Brush,
                    (lineStart.X + lineEnd.X) / 2f - distanceStr.Length / 3f * Font.Size,
                    lineStart.Y - Font.GetHeight());
            }
        }

        private static void DrawEast(Graphics gr, CardinalPoints fig1Cps, CardinalPoints fig2Cps)
        {
            start.X = fig1Cps.East.X;
            start.Y = fig1Cps.East.Y;

            end.X = fig2Cps.West.X;
            end.Y = start.Y;

            DrawHorizontalLineWithDistanceAbove(gr, start, end);

            gr.DrawLine(Pen,
                fig1Cps.East.X, fig1Cps.North.Y,
                fig1Cps.East.X, fig1Cps.South.Y);

            // доводить линию, если не хватает её длины:
            up.X = fig2Cps.West.X;
            up.Y = fig2Cps.North.Y > end.Y ? end.Y : fig2Cps.North.Y;
            // доводить линию, если не хватает её длины:
            low.X = up.X;
            low.Y = fig2Cps.South.Y < end.Y ? end.Y : fig2Cps.South.Y;

            gr.DrawLine(Pen, up, low);
        }
    }
}
