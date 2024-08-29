using PlatigeImage.Export;
using PlatigeImage.Factory.GenerateData;
using PlatigeImage.Factory.ImageComboBoxDataLoaderFactory;
using System.ComponentModel;

namespace PlatigeImage.Forms
{
    public partial class BaseForm : Form
    {
        public int InputValue { get; private set; }
        private readonly ExportManager _exportManager;
        private readonly IImageComboBoxDataLoaderFactory _imageComboBoxDataLoaderFactory;
        private readonly IGenerateDataFactory _generateDataFactory;

        protected IImageComboBoxDataLoaderFactory ImageComboBoxDataLoaderFactory => _imageComboBoxDataLoaderFactory;
        protected IGenerateDataFactory GenerateDataFactory => _generateDataFactory;


        public BaseForm(IImageComboBoxDataLoaderFactory imageComboBoxDataLoaderFactory, IGenerateDataFactory generateDataFactory)
        {
            InitializeComponent();
            _exportManager = new ExportManager();
            _imageComboBoxDataLoaderFactory = imageComboBoxDataLoaderFactory;
            _generateDataFactory = generateDataFactory;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OnConfirm();
            this.gridView.RefreshData();
        }
        protected virtual void OnConfirm() { }


        private void btnExport_Click(object sender, EventArgs e)
        {
            _exportManager.ExportData(gridView);
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gridView.DeleteSelectedRows();
            }
        }

        protected void btnGenerateData_Click(object sender, EventArgs e)
        {
            using (var inputForm = new NumberOfDataToGenerateForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (inputForm.InputValue > 0)
                    {
                        InputValue = inputForm.InputValue;
                        GenerateData();
                    }
                    else
                        MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
                }
            }
        }
        protected virtual void GenerateData() { }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            OnDispose();
        }
        protected virtual void OnDispose() { }    
    }
}