using System.Drawing;
using System.Windows.Forms;

class CustomImageColumn : DataGridViewImageColumn
{   

    public CustomImageColumn( Bitmap errorImage)
    {
        this.CellTemplate = new CustImageCell(errorImage);        
        Image =  errorImage;
       // this.Width=30;
            
    }

    class CustImageCell : DataGridViewImageCell
    {
        public CustImageCell() : this(null) { }
        public CustImageCell(Bitmap defaultImage)   { }

        public override object DefaultNewRowValue { get; }
    }
}
