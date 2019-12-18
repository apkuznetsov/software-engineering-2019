using GasStationMs.App.Elements;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    public class Road : IGasStationElement
    {
        #region изображение
        private static Bitmap image;

        public static Bitmap Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                Icon = Icon.FromHandle(image.GetHicon());
            }
        }

        public static Icon Icon { get; private set; }
        #endregion /изображение
    }
}
