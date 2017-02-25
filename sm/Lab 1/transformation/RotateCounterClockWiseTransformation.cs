using System.Drawing;
using ImageProcessor;

namespace Lab_1.transformation
{
    public class RotateCounterClockWiseTransformation : Transformation
    {
        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Rotate(-90);
        }
    }
}