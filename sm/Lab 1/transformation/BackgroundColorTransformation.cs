using System.Drawing;
using ImageProcessor;

namespace Lab_1.transformation
{
    public class BackgroundColorTransformation : Transformation
    {
        private Color _color;

        public BackgroundColorTransformation(Color color)
        {
            _color = color;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.BackgroundColor(_color);
        }
    }
}
