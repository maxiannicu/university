using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;

namespace Lab_1.transformation
{
    class FlipTransformation : Transformation
    {
        private bool flipVertically;

        public FlipTransformation(bool flipVertically)
        {
            this.flipVertically = flipVertically;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Flip(flipVertically);
        }
    }
}
