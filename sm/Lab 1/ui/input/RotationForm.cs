using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1.ui.input
{
    public partial class RotationForm : Form
    {
        private int _rotationAngle = 0;
        private bool _confirmed = false;

        public int RotationAngle => _rotationAngle;

        public bool Confirmed => _confirmed;

        public RotationForm()
        {
            InitializeComponent();
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            _rotationAngle = Int32.Parse(angle.Text);
            _confirmed = true;
            Close();
        }
    }
}
