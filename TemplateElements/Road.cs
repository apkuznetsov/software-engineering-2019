using GasStationMs.App.Elements;
using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class Road : IGasStationElement
    {
        public static Bitmap Image { get; set; }

        public override string ToString()
        {
            return "Дорога";
        }
    }
}
