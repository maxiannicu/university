using System;
using System.Text;
using System.Windows.Forms;
using Lab_1.core;

namespace Lab_1.ui.info
{
    public partial class ImageInformation : Form
    {
        private ApplicationPresenter _presenter;

        public ImageInformation(ApplicationPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private void ImageInformation_Load(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Format("Width   : {0} px\n", _presenter.Image.Width));
            builder.Append(String.Format("Height  : {0} px\n", _presenter.Image.Height));
            builder.Append(String.Format("Location: {0} px\n", _presenter.Path));

            infoTextBox.Text = builder.ToString();
        }
    }
}
