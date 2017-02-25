using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.core
{
    public class ImageModificationEventArgs : EventArgs
    {
        private Image _image;

        public Image Image => _image;

        public ImageModificationEventArgs(Image image)
        {
            _image = image;
        }
    }
}
