using System;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class Exit : IGasStationElement
    {
        public static Bitmap Image { get; set; }

        public override string ToString()
        {
            return "Выезд";
        }
    }
}
