using System;
using System.Drawing;
using System.IO;
using ImageProcessor;

namespace Lab_1.transformation
{
    public abstract class Transformation
    {
        protected abstract ImageFactory transform(ImageFactory factory);

        public Image apply(Image image)
        {
            Image transformedImage = null;
            using (MemoryStream outStream = new MemoryStream())
            {
                using (var imageFactory = new ImageFactory(true))
                {
                    transform(imageFactory.Load(image))
                        .Save(outStream);
                }
                transformedImage = Image.FromStream(outStream);
            }

            if (transformedImage == null)
            {
                throw new NullReferenceException("Image was not processed");
            }

            return transformedImage;
        }
    }
}
