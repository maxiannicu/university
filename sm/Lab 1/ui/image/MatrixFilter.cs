using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ImageProcessor.Imaging.Filters.Photo;
using Lab_1.core;
using Lab_1.transformation;

namespace Lab_1.ui.image
{
    public partial class MatrixFilter : Form
    {
        private ApplicationPresenter _presenter;
        private IList<FilterModel> _filters; 

        public MatrixFilter(ApplicationPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void applyButton_Click(object sender, System.EventArgs e)
        {
            var selectedIndex = comboBox1.SelectedIndex;
            var model = _filters[selectedIndex];

            _presenter.Apply(new MatrixFilterTransformation(model.Filter));
        }

        private void MatrixFilter_Load(object sender, System.EventArgs e)
        {
            _filters = new List<FilterModel>();
            _filters.Add(new FilterModel(MatrixFilters.BlackWhite, "Black White"));
            _filters.Add(new FilterModel(MatrixFilters.Comic, "Comic"));
            _filters.Add(new FilterModel(MatrixFilters.Gotham, "Gotham"));
            _filters.Add(new FilterModel(MatrixFilters.GreyScale, "Grey Scale"));
            _filters.Add(new FilterModel(MatrixFilters.HiSatch, "Hi Satch"));
            _filters.Add(new FilterModel(MatrixFilters.LoSatch, "Lo Satch"));
            _filters.Add(new FilterModel(MatrixFilters.Invert, "Invert"));
            _filters.Add(new FilterModel(MatrixFilters.Lomograph, "Lomograph"));
            _filters.Add(new FilterModel(MatrixFilters.Polaroid, "Palaroid"));
            _filters.Add(new FilterModel(MatrixFilters.Sepia, "Sepia"));

            foreach (FilterModel model in _filters)
            {
                comboBox1.Items.Add(model.Name);
            }
        }
    }

    class FilterModel
    {
        public IMatrixFilter Filter { get; private set; }

        public String Name { get; private set; }

        public FilterModel(IMatrixFilter filter, string name)
        {
            Filter = filter;
            Name = name;
        }
    }
}
