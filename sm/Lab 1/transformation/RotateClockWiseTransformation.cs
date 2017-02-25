using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;

namespace Lab_1.transformation
{
    public class RotateClockWiseTransformation : Transformation
    {
        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Rotate(90);
        }
    }
}
