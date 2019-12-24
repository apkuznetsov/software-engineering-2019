using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static GasStationMs.App.Modeling.ElementSizeDefiner;

namespace GasStationMs.App.Modeling
{
    internal static class DestinationPointsDefiner
    {
        internal static Dictionary<PictureBox, Point> FuelDispensersDestPoints { get; private set; }

        internal static int FuelingPointDeltaX {get;}= 5;
        internal static int FuelingPointDeltaY { get; } = 10;

        internal static int NoFillingHorizontalLine { get; private set; }
    
        internal static int FilledHorizontalLine { get; private set; }

        internal static int RightPlaygroundBorder { get; private set; }
        internal static int LeftPlaygroundBorder { get; private set; }
        internal static int LeftCarDestroyingEdge { get; private set; }

        // Spawning/destroying car destination points
        internal static Point SpawnPoint { get; private set; }
        internal static Point LeavePointNoFilling { get; private set; }
        internal static Point LeavePointFilled { get; private set; }

        // Destination points to enter/leave gas station
        internal static Point EnterCenter { get; private set; }
        internal static Point ExitCenter { get; private set; }

        internal static Point EnterPoint1 { get; private set; }
        internal static Point EnterPoint2 { get; private set; }
        internal static Point EnterPoint3 { get; private set; }

        internal static Point ExitPoint1 { get; private set; }
        internal static Point ExitPoint2 { get; private set; }
        internal static Point ExitPoint3 { get; private set; }

        internal static void DefineCommonPoints()
        {
            NoFillingHorizontalLine = PanelPlaygroundHeight - 2 * CarHeight - 20;
            FilledHorizontalLine = PanelPlaygroundHeight - 3 * CarHeight - 40;

            RightPlaygroundBorder = PanelPlaygroundWidth;
            LeftPlaygroundBorder = 0;
            LeftCarDestroyingEdge = LeftPlaygroundBorder - 40;

            // Spawning/destroying car destination points
            SpawnPoint = new Point(RightPlaygroundBorder + 50, NoFillingHorizontalLine);
            LeavePointNoFilling = new Point(LeftCarDestroyingEdge, NoFillingHorizontalLine);
            LeavePointFilled = new Point(LeftCarDestroyingEdge, FilledHorizontalLine);
        }

        internal static void DefineElementsPoints(MappedTopology mappedTopology)
        {
            FuelDispensersDestPoints = mappedTopology.FuelDispensersDestPoints;

            var enter = mappedTopology.Enter;
            var exit = mappedTopology.Exit;

            // Destination points to enter/leave gas station
            EnterCenter = new Point(enter.Left + enter.Width / 2,
                enter.Top + enter.Height / 2);
            ExitCenter = new Point(exit.Left + exit.Width / 2,
                exit.Top + exit.Height / 2);

            EnterPoint1 = new Point(SpawnPoint.X - 200, FilledHorizontalLine);
            EnterPoint2 = new Point(EnterCenter.X, EnterCenter.Y + enter.Height);
            EnterPoint3 = new Point(EnterCenter.X, EnterCenter.Y - enter.Height);

            ExitPoint1 = new Point(ExitCenter.X, ExitCenter.Y - exit.Height);
            ExitPoint2 = new Point(ExitCenter.X, ExitCenter.Y + exit.Height);
            ExitPoint3 = new Point(exit.Left, ExitCenter.Y + 2 * exit.Height);
        }
    }
}
