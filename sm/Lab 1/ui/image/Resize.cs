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

namespace Lab_1.ui.info
{
    public partial class Resize : Form
    {
        private ApplicationPresenter _presenter;

        public Resize(ApplicationPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void Resize_Load(object sender, EventArgs e)
        {
            SetDimension(_presenter.Image.Width,_presenter.Image.Height);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resizerButton_Click(object sender, EventArgs e)
        {
            _presenter.Apply(new ResizeTransformation(NewWidth,NewHeight));
        }

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            var newHeight = NewHeight;
            var newWidth = (int)Math.Round(1.0*_presenter.Image.Width * newHeight / _presenter.Image.Height);
            SetDimension(newWidth,newHeight);
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            var newWidth = NewWidth;
            var newHeight = (int)Math.Round(1.0*_presenter.Image.Height*newWidth/_presenter.Image.Width);
            SetDimension(newWidth, newHeight);
        }

        private void SetDimension(int width, int height)
        {
            widthUpDown.Text = String.Format("{0}", width);
            heightUpDown.Text = String.Format("{0}", height);
        }

        private int NewWidth
        {
            get { return Int32.Parse(widthUpDown.Text); }
        }

        private int NewHeight
        {
            get { return Int32.Parse(heightUpDown.Text); }
        }

    }
}
