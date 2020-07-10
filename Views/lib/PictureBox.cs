using System.Drawing;
using System.Windows.Forms;
 
namespace Library
{
    public class PictureBox : System.Windows.Forms.PictureBox
    {
        public PictureBox()
        {   
            this.Size = new Size(60, 60);
            this.ClientSize = new Size(60, 60);
            //this.BackColor = ColorTranslator.FromHtml("#38323e");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}