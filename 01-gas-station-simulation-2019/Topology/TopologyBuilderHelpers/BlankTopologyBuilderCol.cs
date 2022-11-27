using System.Drawing;
using System.Windows.Forms;

namespace GasStationMs.App.Topology.TopologyBuilderHelpers
{
    public class BlankTopologyBuilderCol : DataGridViewImageColumn
    {
        public BlankTopologyBuilderCol()
        {
            Image = GasStationMs.App.Properties.Resources.Blank;
            CellTemplate = new BlankTopologyBuilderCell(GasStationMs.App.Properties.Resources.Blank);
        }

        class BlankTopologyBuilderCell : DataGridViewImageCell
        {
            public BlankTopologyBuilderCell() : this(null) { }
            public BlankTopologyBuilderCell(Bitmap defaultImage) { }

            public override object DefaultNewRowValue { get; }
        }
    }
}
