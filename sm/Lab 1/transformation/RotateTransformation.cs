using ImageProcessor;

namespace Lab_1.transformation
{
    class RotateTransformation : Transformation
    {
        private int _angle;

        public RotateTransformation(int angle)
        {
            _angle = angle;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Rotate(_angle);
        }
    }
}
