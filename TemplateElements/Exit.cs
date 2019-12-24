using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class Exit : IGasStationElement
    {
        #region изображение
        private static Bitmap _image;

        public static Bitmap Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
                Icon = Icon.FromHandle(_image.GetHicon());
            }
        }

        public static Icon Icon { get; private set; }
        #endregion /изображение
    }
}
