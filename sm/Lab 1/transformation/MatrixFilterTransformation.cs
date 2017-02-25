using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.Photo;

namespace Lab_1.transformation
{
    class MatrixFilterTransformation : Transformation
    {
        private IMatrixFilter _filter;

        public MatrixFilterTransformation(IMatrixFilter filter)
        {
            _filter = filter;
        }

        protected override ImageFactory transform(ImageFactory factory)
        {
            return factory.Filter(_filter);
        }
    }
}
