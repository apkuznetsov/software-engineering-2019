﻿using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class ServiceArea : IGasStationElement
    {
        public static Bitmap Image { get; set; }

        public override string ToString()
        {
            return "СЗ";
        }
    }
}
