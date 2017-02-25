using System.Drawing;
using ImageProcessor;

namespace Lab_1.transformation
{
    public class ResizeTransformation : Transformation
    {
        private int _width;
        private int _height;

        public ResizeTransformation(int width, int height)
        {
            _width = width;
            _height = height;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Resize(new Size(_width, _height));
        }
    }
}
