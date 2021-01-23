using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dominio.Librerias
{
    public class uploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void loadImage(PictureBox pBox)
        {
            pBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();

            if (fd.FileName != string.Empty)
            {
                pBox.ImageLocation = fd.FileName;
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
