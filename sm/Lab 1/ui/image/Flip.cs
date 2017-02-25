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
    public partial class Flip : Form
    {
        private ApplicationPresenter _presenter;
        public Flip(ApplicationPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void Flip_Load(object sender, EventArgs e)
        {

        }

        private void verticalButton_Click(object sender, EventArgs e)
        {
            _presenter.Apply(new FlipTransformation(true));
        }

        private void horizontalButton_Click(object sender, EventArgs e)
        {
            _presenter.Apply(new FlipTransformation(false));
        }
    }
}
