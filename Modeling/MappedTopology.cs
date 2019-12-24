using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling
{
    internal class MappedTopology
    {
        internal PictureBox CashCounter { get; set; }
        internal PictureBox Enter { get; set; }
        internal PictureBox Exit { get; set; }
        internal List<PictureBox> FuelDispensersList { get; set; }
        internal List<PictureBox> FuelTanksList { get; set; }

        internal Dictionary<PictureBox, Point> FuelDispensersDestPoints { get; }
        internal Point CashCounterDestinationPoint { get; set; }

        internal MappedTopology()
        {
            FuelDispensersList = new List<PictureBox>();
            FuelTanksList = new List<PictureBox>();
            FuelDispensersDestPoints = new Dictionary<PictureBox, Point>();
        }

        internal void AddFuelDispenserWithDestPoint(PictureBox fuelDispenser, Point pointOfFueling)
        {
            FuelDispensersDestPoints.Add(fuelDispenser, pointOfFueling);
        }
    }
}
