using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_1.core;
using Lab_1.transformation;

namespace Lab_1.ui.image
{
    public partial class Pixelate : Form
    {
        private ApplicationPresenter _presenter;

        public Pixelate(ApplicationPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void Pixelate_Load(object sender, EventArgs e)
        {

        }

        private void pixelateButton_Click(object sender, EventArgs e)
        {
            var size = Int32.Parse(pixelSize.Text);
            _presenter.Apply(new PixelateTransformation(size));
        }
    }
}
