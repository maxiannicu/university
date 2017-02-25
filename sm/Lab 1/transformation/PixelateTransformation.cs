using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;

namespace Lab_1.transformation
{
    class PixelateTransformation : Transformation
    {
        private int _pixelSize;

        public PixelateTransformation(int pixelSize)
        {
            _pixelSize = pixelSize;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Pixelate(_pixelSize);
        }
    }
}
