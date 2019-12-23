using System;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class Entry : IGasStationElement
    {
        public static Bitmap Image { get; set; }

        public override string ToString()
        {
            return "Въезд";
        }
    }
}
