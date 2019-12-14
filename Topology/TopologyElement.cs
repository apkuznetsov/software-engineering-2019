using GasStationMs.App.TemplateElements;
using System.Drawing;

namespace GasStationMs.App.Topology
{
    public class TopologyElement
    {
        private Point point;
        private IGasStationElement gasStationElement;

        public Point Point { get; set; }
        public IGasStationElement GasStationElement { get; set; }
    }
}
