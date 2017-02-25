using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Lab_1.transformation;

namespace Lab_1.core
{
    public class ApplicationPresenter
    {
        private bool _hasModifications;
        private bool _hasOpenImage;
        private Image _image;
        private string _path;
        private ICollection<String> _supportedImageFormats;

        public EventHandler<ImageModificationEventArgs> ImageModificationEventHandler;

        public ApplicationPresenter()
        {
            this._supportedImageFormats = Configuration.SupportedFormats;
        }

        public bool HasModifications => _hasModifications;

        public bool HasOpenImage => _hasOpenImage;

        public Image Image => _image;

        public String Path => _path;

        public ICollection<String> SupportedImageFormats => _supportedImageFormats; 

        public void OpenFile(String path)
        {
            _image = Image.FromFile(path);
            _path = path;
            _hasOpenImage = true;
            _hasModifications = false;
        }

        public void Save()
        {
            _image.Save(_path);
            _hasModifications = false;
        }

        public void SaveAs(String path)
        {
            _image.Save(path);
            _path = path;
            _hasModifications = false;
        }

        public void Apply(Transformation transformation)
        {
            _image = transformation.apply(_image);
            _hasModifications = true;
            ImageModificationEventHandler?.Invoke(this, new ImageModificationEventArgs(_image));
        }

        public void Close()
        {
            _hasOpenImage = false;
        }
    }
}
