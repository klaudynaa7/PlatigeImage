using DevExpress.XtraGrid.Views.Grid;
using PlatigeImage.Resources;
using System.IO;

namespace PlatigeImage.Export
{
    internal class ExportManager
    {
        private readonly Dictionary<string, IExport> _exportStrategies;

        public ExportManager()
        {
            _exportStrategies = new Dictionary<string, IExport>
            {
                { ".csv", new CsvExport() },
                { ".xml", new XmlExport() }
            };
        }

        internal void ExportData(GridView gridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = StringResource.ExportDataFilters;
                saveFileDialog.Title = StringResource.SaveAs;
                saveFileDialog.DefaultExt = StringResource.Csv;
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath);

                    if (_exportStrategies.ContainsKey(fileExtension))
                        _exportStrategies[fileExtension].Export(gridView, filePath);
                    else
                    {
                        string errorMessage = string.Format(StringResource.UnsupportedExportFormat, fileExtension);
                        throw new NotSupportedException(errorMessage);
                    }
                }
            }
        }
    }
}