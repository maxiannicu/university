using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using Lab_1.core;
using Lab_1.transformation;
using Lab_1.ui;
using Lab_1.ui.image;
using Lab_1.ui.info;
using Lab_1.ui.input;

namespace Lab_1
{
    public partial class Application : Form
    {
        private ApplicationPresenter _presenter;

        public Application()
        {
            InitializeComponent();
            this._presenter = new ApplicationPresenter();
            this._presenter.ImageModificationEventHandler += ImageModificationEventHandler;
            ResetMenuState();
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = GetFilters();
            saveFileDialog.Title = "Select where to save";

            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                _presenter.SaveAs(saveFileDialog.FileName);
            }
            ResetMenuState();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_presenter.HasModifications)
            {
                if(AskToSave())
                    Close();
            }
            else
            {
                Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_presenter.HasOpenImage && _presenter.HasModifications)
            {
                if(!AskToSave())
                    return;    
            }

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = GetFilters();
            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                _presenter.OpenFile(openFileDialog.FileName);
                imageBox.Image = _presenter.Image;
            }

            ResetMenuState();
        }

        private bool AskToSave()
        {
            var result = MessageBox.Show("Your work it's not saved. Would you like to save it?", 
                "Warning",
                MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                _presenter.Save();
            }

            return result != DialogResult.Cancel;
        }

        private void ResetMenuState()
        {
            saveasToolStripMenuItem.Enabled = _presenter.HasOpenImage;
            saveToolStripMenuItem.Enabled = _presenter.HasOpenImage && _presenter.HasModifications;
            rotateToolStripMenuItem.Enabled = _presenter.HasOpenImage;
            imageToolStripMenuItem.Enabled = _presenter.HasOpenImage;
        }
        
        private string GetFilters()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _presenter.SupportedImageFormats.Count; i++)
            {
                var supportedImageFormat = _presenter.SupportedImageFormats.ElementAt(i);
                stringBuilder.Append(string.Format("{0}|{0}", supportedImageFormat));
                if (i < _presenter.SupportedImageFormats.Count - 1)
                {
                    stringBuilder.Append('|');
                }
            }
            var s = stringBuilder.ToString();
            return s;
        }

        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTransformation(new RotateClockWiseTransformation());
        }

        private void counterClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTransformation(new RotateCounterClockWiseTransformation());
        }

        private void ApplyTransformation(Transformation transformation)
        {
            _presenter.Apply(transformation);
        }



        private void ImageModificationEventHandler(object sender, ImageModificationEventArgs imageModificationEventArgs)
        {
            imageBox.Image = imageModificationEventArgs.Image;
            ResetMenuState();
        }

        private void specificDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var rotationForm = new RotationForm())
            {
                rotationForm.ShowDialog(this);
                if (rotationForm.Confirmed)
                {
                    var rotationAngle = rotationForm.RotationAngle;
                    ApplyTransformation(new RotateTransformation(rotationAngle));
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ImageInformation(_presenter))
            {
                form.ShowDialog(this);
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Resize(_presenter))
            {
                form.ShowDialog(this);
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var color = colorDialog.Color;
                _presenter.Apply(new BackgroundColorTransformation(color));
            }
        }

        private void flipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Flip(_presenter))
            {
                form.ShowDialog(this);
            }
        }

        private void pixelateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Pixelate(_presenter))
            {
                form.ShowDialog(this);
            }
        }

        private void matrixFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new MatrixFilter(_presenter))
            {
                form.ShowDialog(this);
            }
        }
    }
}
